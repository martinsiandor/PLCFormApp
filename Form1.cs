using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using EncryptString;
using System.IO;
using System.Threading;


namespace PLCFormApp
{
	public partial class Form1 : Form
	{
		private string plcIp = "192.168.1.8";
		private string clientIp = "127.0.0.1";
		private int tcpPort = 2000;

		private S7Client client = new S7Client();

		private TcpClient tcpClient;
		private TcpClient _tcpClient;
		private NetworkStream stream;
		private NetworkStream _stream;
		private bool _isConnected = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

				
		}
	

		private void lblPlcIp_Click(object sender, EventArgs e)
		{

		}

		private void lblTcpIp_Click(object sender, EventArgs e)
		{
		
		}

		private void cmbValToPlcDataTypes_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtValToPLc_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtDataTypeValFromPlc_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtValFromPlc_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPlcIp_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtServerPort_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnPlcConnect_Click(object sender, EventArgs e)
		{
			string ip = txtPlcIp.Text;

			if(ip != "" && ip == this.plcIp)
			{
				btnPlcConnect.Enabled = false;
				btnPlcDisconnect.Enabled = true;
				txtPlcIp.Enabled = false;

				int result = client.ConnectTo(txtPlcIp.Text, 0, 1);
				if (result != 0) lblPlcState.Text = "Něco se pokazilo: " + result;
				else lblPlcState.Text = "Připojení bylo úspěšné";
				txtLog.Text += "\n ("+ DateTime.Now.ToString()+ ") Connected to " + ip;
			}
			
		}

		private void btnPlcDisconnect_Click(object sender, EventArgs e)
		{
			btnPlcConnect.Enabled = true;
			btnPlcDisconnect.Enabled = false;
			txtPlcIp.Enabled = true;

			client.Disconnect();

			string ip = txtPlcIp.Text;

			lblPlcState.Text = "Úspěšně odpojeno ("+ip+")";

			txtLog.Text += "\n ("+ DateTime.Now.ToString() + ") Disconnected from " + ip;
		}

		

		private async void btnTcpIpConnect_Click(object sender, EventArgs e)
		{
			string ip = txtClientIp.Text;
			string port = txtClientPort.Text;

			if (ip != string.Empty && port != string.Empty)
			{
				string numPattern = @"^\d+$";
				Regex regex = new Regex(numPattern);

				if (checkIp(ip) && regex.IsMatch(port))
				{
					if(ip == clientIp && port == tcpPort.ToString())
					{
						btnTcpIpConnect.Enabled = false;
						btnTcpIpDisconnect.Enabled = true;

						//connectTcpClient(ip, int.Parse(port));
						try
						{
							await connectAsyncTcpClient(ip, int.Parse(port));
							_isConnected = true;

							while (_isConnected)
							{
								string response = await asyncTcpGetData();

								writeLog(response);

								if(txtValToServer.Text != "" || txtValToServer.Text != null) 
								{
									await asyncTcpSendData(txtValToServer.Text);
								}

							}
							
						}
						catch (Exception exception)
						{
							writeLog("Connection rejected due to: "+exception.Message);
						}

						writeLog("Connected to server: " + ip + " on " + port);
					}
					else
					{
						writeLog("Connection rejected - input does not match");
					}
				}
				else
				{
					writeLog("IP address or port has wrong pattern");
				}

			}
			else
			{
				string txt = "Connection to the server was unsuccessful - ";
				if(ip == string.Empty && port == string.Empty)
				{
					writeLog(txt + "client ip and port was empty");
				}
				else
				{
					if(ip == string.Empty)
					{
						writeLog(txt + "client ip was empty");
					}

					if(port == string.Empty)
					{
						writeLog(txt + "port was empty");
					}
				}
			}
			
		}

		private void btnSendToPlc_Click(object sender, EventArgs e)
		{
			string data = txtValToPLc.Text;
			plcSendData(data);
		}

		private void btnGetValue_Click(object sender, EventArgs e)
		{
			byte[] rBuffer = new byte[12];

			int result = client.DBRead(1, 0, 2, rBuffer);
			var readValue = S7.GetIntAt(rBuffer, 0);

			txtValFromPlc.Text = readValue.ToString();
			txtDataTypeValFromPlc.Text = "Int";

			writeLog("Received from PLC: " + readValue.ToString());
		}

		private void txtLog_TextChanged(object sender, EventArgs e)
		{
			txtLog.SelectionStart = txtLog.Text.Length;
			txtLog.ScrollToCaret();
		}

		

		private void btnSendValToServer_Click(object sender, EventArgs e)
		{
			tcpSendData(txtValToServer.Text);
			//await asyncTcpSendData(txtValToServer.Text);
			writeLog("Sent to TCP / IP: " + txtValToServer.Text);
		}

		private void btnGetValFromServer_Click(object sender, EventArgs e)
		{

			string responseData = tcpGetData();
			//string responseData = await asyncTcpGetData();

			//plcSendData(responseData);

			writeLog("Received from TCP/IP: " + responseData);
		}

		private void btnTcpIpDisconnect_Click(object sender, EventArgs e)
		{
			btnTcpIpConnect.Enabled = true;
			btnTcpIpDisconnect.Enabled = false;

			disconnectTcpClient();
		}

		private void connectTcpClient(string ip, int port)
		{
			tcpClient = new TcpClient(ip, port); 

			stream = tcpClient.GetStream();

			writeLog("Connected to TCP / IP");
			//disconnectTcpClient();
		}

		private async Task connectAsyncTcpClient(string ip, int port)
		{
			_tcpClient = new TcpClient();
			await _tcpClient.ConnectAsync(ip, port);
			_stream = _tcpClient.GetStream();

		}

		private async Task asyncTcpSendData(string data)
		{
			data = createTcpMsg(data);
			byte[] buffer = Encoding.ASCII.GetBytes(data + ".");
			await _stream.WriteAsync(buffer, 0, buffer.Length);
		}

		private async Task<string> asyncTcpGetData()
		{
			byte[] buffer = new byte[1024];
			int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
			string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

			return response;
		}

		private void disconnectTcpClient()
		{
			_tcpClient.Close();
			_stream.Close();

			writeLog("Disconnected from TCP/IP");
		}


		private void writeLog(string text)
		{
			txtLog.Text += "\n (" + DateTime.Now.ToString() + ") " + text + ".";
		}

		public bool checkIp(string ip)
		{
			if (ip == string.Empty)
			{
				return false;
			}
			else
			{
				string ipPattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
				Regex regex = new Regex(ipPattern);

				return regex.IsMatch(ip);
			}
		}

		public void tcpSendData(string data)
		{
			data = createTcpMsg(data);
			byte[] buffer = Encoding.ASCII.GetBytes(data+".");
			stream.Write(buffer, 0, buffer.Length);
		}

		public string tcpGetData(int offset)
		{
			byte[] buffer = new byte[1024];
			int bytesRead = stream.Read(buffer, offset, buffer.Length);
			string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

			return response;
		}

		public string tcpGetData()
		{
			byte[] buffer = new byte[1024];
			int bytesRead = stream.Read(buffer, 0, buffer.Length);
			string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

			return response;
		}

		public int plcSendData(string data)
		{
			byte[] wBuffer = new byte[12];
			byte writeValue = byte.Parse(data);
			S7.SetIntAt(wBuffer, 0, writeValue);
			int result = client.DBWrite(1, 0, 2, wBuffer);

			return result;
		}

		public string plcGetData()
		{
			byte[] rBuffer = new byte[12];
			int result = client.DBRead(1, 0, 2, rBuffer);

			return S7.GetIntAt(rBuffer, 0).ToString();
		}

		public string createTcpMsg(string message)
		{
			byte size = 100;
			byte speed = 2;
			byte round = 1;
			byte mode = 1;
			byte state = 1;
			byte side = 1;

			string reqId = "x#@?5451afBq";
			string resId = "zU14x@ceQdR#";

			/*string reqId = StringCipher.Encrypt(RandomString(8), "12345");
			string resId = StringCipher.Encrypt(RandomString(8), "54321");*/

			DateTime date = DateTime.Now;
			TimeSpan span = new TimeSpan(date.Ticks);

			speed = message.Length != 0 ? byte.Parse(message) : speed;

			return span.TotalSeconds.ToString() + ";" + reqId + ";" + resId + ";" + state + ";" + side + ";" + size + ";" + round + ";" + mode + ";" +  speed;
		}

		public string createTcpMsg(byte state, byte side, byte size, bool round, byte mode, byte speed)
		{
			string reqId = "x#@?5451afBq";
			string resId = "zU14x@ceQdR#";

			/*string reqId = StringCipher.Encrypt(RandomString(8), "12345");
			string resId = StringCipher.Encrypt(RandomString(8), "54321");*/

			return new TimeSpan(DateTime.Now.Ticks).TotalSeconds.ToString() + ";" + state + ";" + reqId + ";" + resId + ";" + state + ";" + side + ";" + size + ";" + round + ";" + mode + ";" + speed;
		}

		public static string RandomString(int length)
		{
			Random random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
		}

		/*public void sendFromTcpToPlc()
		{
			byte[] buffer = new byte[1024];
			int bytesRead = stream.Read(buffer, 0, buffer.Length);
			string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

			byte[] wBuffer = new byte[12];
			byte writeValue = byte.Parse(response);
			S7.SetIntAt(wBuffer, 1, writeValue);
			int result = client.DBWrite(1, 0, 2, wBuffer);
		}

		public void sendFromPlcToTcp()
		{

		}*/
	}
}
