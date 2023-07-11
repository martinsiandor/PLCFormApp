
namespace PLCFormApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblPlc = new System.Windows.Forms.Label();
			this.lblTcpIp = new System.Windows.Forms.Label();
			this.lblPlcIp = new System.Windows.Forms.Label();
			this.txtPlcIp = new System.Windows.Forms.TextBox();
			this.lblClientPort = new System.Windows.Forms.Label();
			this.lblClientIp = new System.Windows.Forms.Label();
			this.txtClientIp = new System.Windows.Forms.TextBox();
			this.txtClientPort = new System.Windows.Forms.TextBox();
			this.btnPlcConnect = new System.Windows.Forms.Button();
			this.btnTcpIpConnect = new System.Windows.Forms.Button();
			this.btnTcpIpDisconnect = new System.Windows.Forms.Button();
			this.btnPlcDisconnect = new System.Windows.Forms.Button();
			this.lblTcpState = new System.Windows.Forms.Label();
			this.lblPlcState = new System.Windows.Forms.Label();
			this.lblLog = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.lblValToPlc = new System.Windows.Forms.Label();
			this.cmbValToPlcDataTypes = new System.Windows.Forms.ComboBox();
			this.txtValToPLc = new System.Windows.Forms.TextBox();
			this.lblValFromPLc = new System.Windows.Forms.Label();
			this.txtValFromPlc = new System.Windows.Forms.TextBox();
			this.txtDataTypeValFromPlc = new System.Windows.Forms.TextBox();
			this.btnSendToPlc = new System.Windows.Forms.Button();
			this.btnGetValue = new System.Windows.Forms.Button();
			this.btnGetValFromServer = new System.Windows.Forms.Button();
			this.btnSendValToServer = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtValFromServer = new System.Windows.Forms.TextBox();
			this.lblValFromServer = new System.Windows.Forms.Label();
			this.txtValToServer = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblValToServer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPlc
			// 
			this.lblPlc.AutoSize = true;
			this.lblPlc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPlc.Location = new System.Drawing.Point(87, 74);
			this.lblPlc.Name = "lblPlc";
			this.lblPlc.Size = new System.Drawing.Size(132, 41);
			this.lblPlc.TabIndex = 0;
			this.lblPlc.Text = "PLC (S7):";
			// 
			// lblTcpIp
			// 
			this.lblTcpIp.AutoSize = true;
			this.lblTcpIp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTcpIp.Location = new System.Drawing.Point(87, 246);
			this.lblTcpIp.Name = "lblTcpIp";
			this.lblTcpIp.Size = new System.Drawing.Size(193, 41);
			this.lblTcpIp.TabIndex = 1;
			this.lblTcpIp.Text = "TCP/IP klient:";
			this.lblTcpIp.Click += new System.EventHandler(this.lblTcpIp_Click);
			// 
			// lblPlcIp
			// 
			this.lblPlcIp.AutoSize = true;
			this.lblPlcIp.Location = new System.Drawing.Point(87, 141);
			this.lblPlcIp.Name = "lblPlcIp";
			this.lblPlcIp.Size = new System.Drawing.Size(31, 25);
			this.lblPlcIp.TabIndex = 2;
			this.lblPlcIp.Text = "IP:";
			this.lblPlcIp.Click += new System.EventHandler(this.lblPlcIp_Click);
			// 
			// txtPlcIp
			// 
			this.txtPlcIp.Location = new System.Drawing.Point(167, 141);
			this.txtPlcIp.Name = "txtPlcIp";
			this.txtPlcIp.Size = new System.Drawing.Size(288, 31);
			this.txtPlcIp.TabIndex = 3;
			this.txtPlcIp.TextChanged += new System.EventHandler(this.txtPlcIp_TextChanged);
			// 
			// lblClientPort
			// 
			this.lblClientPort.AutoSize = true;
			this.lblClientPort.Location = new System.Drawing.Point(87, 385);
			this.lblClientPort.Name = "lblClientPort";
			this.lblClientPort.Size = new System.Drawing.Size(48, 25);
			this.lblClientPort.TabIndex = 8;
			this.lblClientPort.Text = "Port:";
			// 
			// lblClientIp
			// 
			this.lblClientIp.AutoSize = true;
			this.lblClientIp.Location = new System.Drawing.Point(87, 348);
			this.lblClientIp.Name = "lblClientIp";
			this.lblClientIp.Size = new System.Drawing.Size(31, 25);
			this.lblClientIp.TabIndex = 9;
			this.lblClientIp.Text = "IP:";
			// 
			// txtClientIp
			// 
			this.txtClientIp.Location = new System.Drawing.Point(167, 348);
			this.txtClientIp.Name = "txtClientIp";
			this.txtClientIp.Size = new System.Drawing.Size(288, 31);
			this.txtClientIp.TabIndex = 10;
			// 
			// txtClientPort
			// 
			this.txtClientPort.Location = new System.Drawing.Point(167, 385);
			this.txtClientPort.Name = "txtClientPort";
			this.txtClientPort.Size = new System.Drawing.Size(288, 31);
			this.txtClientPort.TabIndex = 11;
			// 
			// btnPlcConnect
			// 
			this.btnPlcConnect.Location = new System.Drawing.Point(519, 74);
			this.btnPlcConnect.Name = "btnPlcConnect";
			this.btnPlcConnect.Size = new System.Drawing.Size(212, 69);
			this.btnPlcConnect.TabIndex = 12;
			this.btnPlcConnect.Text = "Připojit k PLC";
			this.btnPlcConnect.UseVisualStyleBackColor = true;
			this.btnPlcConnect.Click += new System.EventHandler(this.btnPlcConnect_Click);
			// 
			// btnTcpIpConnect
			// 
			this.btnTcpIpConnect.Location = new System.Drawing.Point(87, 453);
			this.btnTcpIpConnect.Name = "btnTcpIpConnect";
			this.btnTcpIpConnect.Size = new System.Drawing.Size(212, 69);
			this.btnTcpIpConnect.TabIndex = 13;
			this.btnTcpIpConnect.Text = "Připojit ";
			this.btnTcpIpConnect.UseVisualStyleBackColor = true;
			this.btnTcpIpConnect.Click += new System.EventHandler(this.btnTcpIpConnect_Click);
			// 
			// btnTcpIpDisconnect
			// 
			this.btnTcpIpDisconnect.Enabled = false;
			this.btnTcpIpDisconnect.Location = new System.Drawing.Point(320, 453);
			this.btnTcpIpDisconnect.Name = "btnTcpIpDisconnect";
			this.btnTcpIpDisconnect.Size = new System.Drawing.Size(212, 69);
			this.btnTcpIpDisconnect.TabIndex = 14;
			this.btnTcpIpDisconnect.Text = "Odpojit";
			this.btnTcpIpDisconnect.UseVisualStyleBackColor = true;
			this.btnTcpIpDisconnect.Click += new System.EventHandler(this.btnTcpIpDisconnect_Click);
			// 
			// btnPlcDisconnect
			// 
			this.btnPlcDisconnect.Enabled = false;
			this.btnPlcDisconnect.Location = new System.Drawing.Point(519, 161);
			this.btnPlcDisconnect.Name = "btnPlcDisconnect";
			this.btnPlcDisconnect.Size = new System.Drawing.Size(212, 69);
			this.btnPlcDisconnect.TabIndex = 15;
			this.btnPlcDisconnect.Text = "Odpojit";
			this.btnPlcDisconnect.UseVisualStyleBackColor = true;
			this.btnPlcDisconnect.Click += new System.EventHandler(this.btnPlcDisconnect_Click);
			// 
			// lblTcpState
			// 
			this.lblTcpState.AutoSize = true;
			this.lblTcpState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTcpState.ForeColor = System.Drawing.Color.Crimson;
			this.lblTcpState.Location = new System.Drawing.Point(42, 554);
			this.lblTcpState.Name = "lblTcpState";
			this.lblTcpState.Size = new System.Drawing.Size(0, 30);
			this.lblTcpState.TabIndex = 16;
			// 
			// lblPlcState
			// 
			this.lblPlcState.AutoSize = true;
			this.lblPlcState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPlcState.ForeColor = System.Drawing.Color.Crimson;
			this.lblPlcState.Location = new System.Drawing.Point(474, 224);
			this.lblPlcState.Name = "lblPlcState";
			this.lblPlcState.Size = new System.Drawing.Size(0, 30);
			this.lblPlcState.TabIndex = 17;
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Location = new System.Drawing.Point(42, 584);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(46, 25);
			this.lblLog.TabIndex = 19;
			this.lblLog.Text = "Log:";
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtLog.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLog.ForeColor = System.Drawing.SystemColors.Window;
			this.txtLog.Location = new System.Drawing.Point(31, 612);
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(821, 455);
			this.txtLog.TabIndex = 20;
			this.txtLog.Text = "";
			this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
			// 
			// lblValToPlc
			// 
			this.lblValToPlc.AutoSize = true;
			this.lblValToPlc.Location = new System.Drawing.Point(987, 96);
			this.lblValToPlc.Name = "lblValToPlc";
			this.lblValToPlc.Size = new System.Drawing.Size(147, 25);
			this.lblValToPlc.TabIndex = 22;
			this.lblValToPlc.Text = "Hodnota do PLC:";
			// 
			// cmbValToPlcDataTypes
			// 
			this.cmbValToPlcDataTypes.FormattingEnabled = true;
			this.cmbValToPlcDataTypes.Location = new System.Drawing.Point(1164, 96);
			this.cmbValToPlcDataTypes.Name = "cmbValToPlcDataTypes";
			this.cmbValToPlcDataTypes.Size = new System.Drawing.Size(131, 33);
			this.cmbValToPlcDataTypes.TabIndex = 23;
			this.cmbValToPlcDataTypes.SelectedIndexChanged += new System.EventHandler(this.cmbValToPlcDataTypes_SelectedIndexChanged);
			// 
			// txtValToPLc
			// 
			this.txtValToPLc.Location = new System.Drawing.Point(1319, 98);
			this.txtValToPLc.Name = "txtValToPLc";
			this.txtValToPLc.Size = new System.Drawing.Size(306, 31);
			this.txtValToPLc.TabIndex = 24;
			this.txtValToPLc.TextChanged += new System.EventHandler(this.txtValToPLc_TextChanged);
			// 
			// lblValFromPLc
			// 
			this.lblValFromPLc.AutoSize = true;
			this.lblValFromPLc.Location = new System.Drawing.Point(987, 205);
			this.lblValFromPLc.Name = "lblValFromPLc";
			this.lblValFromPLc.Size = new System.Drawing.Size(133, 25);
			this.lblValFromPLc.TabIndex = 25;
			this.lblValFromPLc.Text = "Hodnota z PLC:";
			// 
			// txtValFromPlc
			// 
			this.txtValFromPlc.BackColor = System.Drawing.Color.White;
			this.txtValFromPlc.Enabled = false;
			this.txtValFromPlc.Location = new System.Drawing.Point(1319, 199);
			this.txtValFromPlc.Name = "txtValFromPlc";
			this.txtValFromPlc.ReadOnly = true;
			this.txtValFromPlc.Size = new System.Drawing.Size(306, 31);
			this.txtValFromPlc.TabIndex = 26;
			this.txtValFromPlc.TextChanged += new System.EventHandler(this.txtValFromPlc_TextChanged);
			// 
			// txtDataTypeValFromPlc
			// 
			this.txtDataTypeValFromPlc.BackColor = System.Drawing.Color.White;
			this.txtDataTypeValFromPlc.Enabled = false;
			this.txtDataTypeValFromPlc.Location = new System.Drawing.Point(1164, 202);
			this.txtDataTypeValFromPlc.Name = "txtDataTypeValFromPlc";
			this.txtDataTypeValFromPlc.ReadOnly = true;
			this.txtDataTypeValFromPlc.Size = new System.Drawing.Size(131, 31);
			this.txtDataTypeValFromPlc.TabIndex = 27;
			this.txtDataTypeValFromPlc.TextChanged += new System.EventHandler(this.txtDataTypeValFromPlc_TextChanged);
			// 
			// btnSendToPlc
			// 
			this.btnSendToPlc.Location = new System.Drawing.Point(1642, 94);
			this.btnSendToPlc.Name = "btnSendToPlc";
			this.btnSendToPlc.Size = new System.Drawing.Size(112, 34);
			this.btnSendToPlc.TabIndex = 28;
			this.btnSendToPlc.Text = "Odeslat";
			this.btnSendToPlc.UseVisualStyleBackColor = true;
			this.btnSendToPlc.Click += new System.EventHandler(this.btnSendToPlc_Click);
			// 
			// btnGetValue
			// 
			this.btnGetValue.Location = new System.Drawing.Point(1642, 196);
			this.btnGetValue.Name = "btnGetValue";
			this.btnGetValue.Size = new System.Drawing.Size(229, 34);
			this.btnGetValue.TabIndex = 29;
			this.btnGetValue.Text = "Aktualizovat hodnotu";
			this.btnGetValue.UseVisualStyleBackColor = true;
			this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
			// 
			// btnGetValFromServer
			// 
			this.btnGetValFromServer.Location = new System.Drawing.Point(1642, 445);
			this.btnGetValFromServer.Name = "btnGetValFromServer";
			this.btnGetValFromServer.Size = new System.Drawing.Size(229, 34);
			this.btnGetValFromServer.TabIndex = 37;
			this.btnGetValFromServer.Text = "Aktualizovat hodnotu";
			this.btnGetValFromServer.UseVisualStyleBackColor = true;
			this.btnGetValFromServer.Click += new System.EventHandler(this.btnGetValFromServer_Click);
			// 
			// btnSendValToServer
			// 
			this.btnSendValToServer.Location = new System.Drawing.Point(1642, 343);
			this.btnSendValToServer.Name = "btnSendValToServer";
			this.btnSendValToServer.Size = new System.Drawing.Size(112, 34);
			this.btnSendValToServer.TabIndex = 36;
			this.btnSendValToServer.Text = "Odeslat";
			this.btnSendValToServer.UseVisualStyleBackColor = true;
			this.btnSendValToServer.Click += new System.EventHandler(this.btnSendValToServer_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(1164, 451);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(131, 31);
			this.textBox1.TabIndex = 35;
			// 
			// txtValFromServer
			// 
			this.txtValFromServer.BackColor = System.Drawing.Color.White;
			this.txtValFromServer.Enabled = false;
			this.txtValFromServer.Location = new System.Drawing.Point(1319, 448);
			this.txtValFromServer.Name = "txtValFromServer";
			this.txtValFromServer.ReadOnly = true;
			this.txtValFromServer.Size = new System.Drawing.Size(306, 31);
			this.txtValFromServer.TabIndex = 34;
			// 
			// lblValFromServer
			// 
			this.lblValFromServer.AutoSize = true;
			this.lblValFromServer.Location = new System.Drawing.Point(987, 454);
			this.lblValFromServer.Name = "lblValFromServer";
			this.lblValFromServer.Size = new System.Drawing.Size(171, 25);
			this.lblValFromServer.TabIndex = 33;
			this.lblValFromServer.Text = "Hodnota ze serveru:";
			// 
			// txtValToServer
			// 
			this.txtValToServer.Location = new System.Drawing.Point(1319, 347);
			this.txtValToServer.Name = "txtValToServer";
			this.txtValToServer.Size = new System.Drawing.Size(306, 31);
			this.txtValToServer.TabIndex = 32;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(1164, 345);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(131, 33);
			this.comboBox1.TabIndex = 31;
			// 
			// lblValToServer
			// 
			this.lblValToServer.AutoSize = true;
			this.lblValToServer.Location = new System.Drawing.Point(987, 345);
			this.lblValToServer.Name = "lblValToServer";
			this.lblValToServer.Size = new System.Drawing.Size(163, 25);
			this.lblValToServer.TabIndex = 30;
			this.lblValToServer.Text = "Hodnota na server:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1932, 1083);
			this.Controls.Add(this.btnGetValFromServer);
			this.Controls.Add(this.btnSendValToServer);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtValFromServer);
			this.Controls.Add(this.lblValFromServer);
			this.Controls.Add(this.txtValToServer);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblValToServer);
			this.Controls.Add(this.btnGetValue);
			this.Controls.Add(this.btnSendToPlc);
			this.Controls.Add(this.txtDataTypeValFromPlc);
			this.Controls.Add(this.txtValFromPlc);
			this.Controls.Add(this.lblValFromPLc);
			this.Controls.Add(this.txtValToPLc);
			this.Controls.Add(this.cmbValToPlcDataTypes);
			this.Controls.Add(this.lblValToPlc);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.lblPlcState);
			this.Controls.Add(this.lblTcpState);
			this.Controls.Add(this.btnPlcDisconnect);
			this.Controls.Add(this.btnTcpIpDisconnect);
			this.Controls.Add(this.btnTcpIpConnect);
			this.Controls.Add(this.btnPlcConnect);
			this.Controls.Add(this.txtClientPort);
			this.Controls.Add(this.txtClientIp);
			this.Controls.Add(this.lblClientIp);
			this.Controls.Add(this.lblClientPort);
			this.Controls.Add(this.txtPlcIp);
			this.Controls.Add(this.lblPlcIp);
			this.Controls.Add(this.lblTcpIp);
			this.Controls.Add(this.lblPlc);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPlc;
		private System.Windows.Forms.Label lblTcpIp;
		private System.Windows.Forms.Label lblPlcIp;
		private System.Windows.Forms.TextBox txtPlcIp;
		private System.Windows.Forms.Label lblClientPort;
		private System.Windows.Forms.Label lblClientIp;
		private System.Windows.Forms.TextBox txtClientIp;
		private System.Windows.Forms.TextBox txtClientPort;
		private System.Windows.Forms.Button btnPlcConnect;
		private System.Windows.Forms.Button btnTcpIpConnect;
		private System.Windows.Forms.Button btnTcpIpDisconnect;
		private System.Windows.Forms.Button btnPlcDisconnect;
		private System.Windows.Forms.Label lblTcpState;
		private System.Windows.Forms.Label lblPlcState;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.RichTextBox txtLog;
		private System.Windows.Forms.Label lblValToPlc;
		private System.Windows.Forms.ComboBox cmbValToPlcDataTypes;
		private System.Windows.Forms.TextBox txtValToPLc;
		private System.Windows.Forms.Label lblValFromPLc;
		private System.Windows.Forms.TextBox txtValFromPlc;
		private System.Windows.Forms.TextBox txtDataTypeValFromPlc;
		private System.Windows.Forms.Button btnSendToPlc;
		private System.Windows.Forms.Button btnGetValue;
		private System.Windows.Forms.Button btnGetValFromServer;
		private System.Windows.Forms.Button btnSendValToServer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtValFromServer;
		private System.Windows.Forms.Label lblValFromServer;
		private System.Windows.Forms.TextBox txtValToServer;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblValToServer;
	}
}

