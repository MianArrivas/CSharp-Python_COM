namespace Python_JSON_Communication
{
    partial class Frm_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Mesage = new System.Windows.Forms.Label();
            this.TxtBx_Message = new System.Windows.Forms.TextBox();
            this.Btn_SendMessage = new System.Windows.Forms.Button();
            this.Lbl2_MessageReceived = new System.Windows.Forms.Label();
            this.TxtBx_MessageReceived = new System.Windows.Forms.TextBox();
            this.Tmr_CheckFile = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mesage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBx_Message, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_SendMessage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl2_MessageReceived, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBx_MessageReceived, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 187);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Mesage
            // 
            this.lbl_Mesage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Mesage.AutoSize = true;
            this.lbl_Mesage.Location = new System.Drawing.Point(6, 20);
            this.lbl_Mesage.Name = "lbl_Mesage";
            this.lbl_Mesage.Size = new System.Drawing.Size(50, 13);
            this.lbl_Mesage.TabIndex = 0;
            this.lbl_Mesage.Text = "Message";
            // 
            // TxtBx_Message
            // 
            this.TxtBx_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBx_Message.Location = new System.Drawing.Point(66, 16);
            this.TxtBx_Message.Name = "TxtBx_Message";
            this.TxtBx_Message.Size = new System.Drawing.Size(174, 20);
            this.TxtBx_Message.TabIndex = 1;
            // 
            // Btn_SendMessage
            // 
            this.Btn_SendMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_SendMessage, 2);
            this.Btn_SendMessage.Location = new System.Drawing.Point(70, 59);
            this.Btn_SendMessage.Name = "Btn_SendMessage";
            this.Btn_SendMessage.Size = new System.Drawing.Size(105, 29);
            this.Btn_SendMessage.TabIndex = 2;
            this.Btn_SendMessage.Text = "Send Message";
            this.Btn_SendMessage.UseVisualStyleBackColor = true;
            this.Btn_SendMessage.Click += new System.EventHandler(this.Btn_SendMessage_Click);
            // 
            // Lbl2_MessageReceived
            // 
            this.Lbl2_MessageReceived.AutoSize = true;
            this.Lbl2_MessageReceived.Location = new System.Drawing.Point(6, 97);
            this.Lbl2_MessageReceived.Name = "Lbl2_MessageReceived";
            this.Lbl2_MessageReceived.Size = new System.Drawing.Size(35, 13);
            this.Lbl2_MessageReceived.TabIndex = 0;
            this.Lbl2_MessageReceived.Text = "label2";
            // 
            // TxtBx_MessageReceived
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtBx_MessageReceived, 2);
            this.TxtBx_MessageReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBx_MessageReceived.Location = new System.Drawing.Point(6, 119);
            this.TxtBx_MessageReceived.Multiline = true;
            this.TxtBx_MessageReceived.Name = "TxtBx_MessageReceived";
            this.TxtBx_MessageReceived.ReadOnly = true;
            this.TxtBx_MessageReceived.Size = new System.Drawing.Size(234, 62);
            this.TxtBx_MessageReceived.TabIndex = 0;
            // 
            // Tmr_CheckFile
            // 
            this.Tmr_CheckFile.Enabled = true;
            this.Tmr_CheckFile.Tick += new System.EventHandler(this.Tmr_CheckFile_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 195);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Main";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Mesage;
        private System.Windows.Forms.TextBox TxtBx_Message;
        private System.Windows.Forms.Button Btn_SendMessage;
        private System.Windows.Forms.Label Lbl2_MessageReceived;
        private System.Windows.Forms.TextBox TxtBx_MessageReceived;
        private System.Windows.Forms.Timer Tmr_CheckFile;
    }
}

