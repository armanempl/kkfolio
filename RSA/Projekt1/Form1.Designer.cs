
namespace Projekt1
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
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            PubFileSelect = new System.Windows.Forms.Button();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            buttonEncrypt = new System.Windows.Forms.Button();
            buttonDecrypt = new System.Windows.Forms.Button();
            PubFilePath = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            PubKeyPath = new System.Windows.Forms.TextBox();
            PrivKeyPath = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            PubKeySelect = new System.Windows.Forms.Button();
            PrivKeySelect = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            PrivFilePath = new System.Windows.Forms.TextBox();
            PrivFileSelect = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            privpathholder = new System.Windows.Forms.TextBox();
            pubpathholder = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // PubFileSelect
            // 
            PubFileSelect.AllowDrop = true;
            PubFileSelect.Location = new System.Drawing.Point(142, 164);
            PubFileSelect.Name = "PubFileSelect";
            PubFileSelect.Size = new System.Drawing.Size(108, 23);
            PubFileSelect.TabIndex = 0;
            PubFileSelect.Text = "Wybierz plik...";
            PubFileSelect.UseVisualStyleBackColor = true;
            PubFileSelect.Click += PubFileSelect_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new System.Drawing.Point(138, 292);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            buttonEncrypt.TabIndex = 1;
            buttonEncrypt.Text = "Szyfruj";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += button2_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new System.Drawing.Point(603, 291);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            buttonDecrypt.TabIndex = 2;
            buttonDecrypt.Text = "Odszyfruj";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += button3_Click;
            // 
            // PubFilePath
            // 
            PubFilePath.Location = new System.Drawing.Point(93, 135);
            PubFilePath.Name = "PubFilePath";
            PubFilePath.Size = new System.Drawing.Size(204, 23);
            PubFilePath.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(196, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(451, 15);
            label3.TabIndex = 8;
            label3.Text = "Wybierz plik do zaszyfrowania lub odszyfrowania z wykorzystaniem szyfrowania RSA:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Location = new System.Drawing.Point(12, 156);
            label4.MaximumSize = new System.Drawing.Size(0, 2);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 2);
            label4.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(327, 33);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(147, 47);
            button4.TabIndex = 10;
            button4.Text = "Wygeneruj parę kluczy (publiczny/prywatny)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // PubKeyPath
            // 
            PubKeyPath.Location = new System.Drawing.Point(93, 219);
            PubKeyPath.Name = "PubKeyPath";
            PubKeyPath.Size = new System.Drawing.Size(204, 23);
            PubKeyPath.TabIndex = 13;
            // 
            // PrivKeyPath
            // 
            PrivKeyPath.Location = new System.Drawing.Point(504, 218);
            PrivKeyPath.Name = "PrivKeyPath";
            PrivKeyPath.Size = new System.Drawing.Size(202, 23);
            PrivKeyPath.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(93, 201);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 15);
            label1.TabIndex = 15;
            label1.Text = "Wskaż lokalizację klucza publicznego:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(504, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(202, 15);
            label2.TabIndex = 16;
            label2.Text = "Wskaż lokalizację klucza prywatnego:";
            // 
            // PubKeySelect
            // 
            PubKeySelect.Location = new System.Drawing.Point(129, 248);
            PubKeySelect.Name = "PubKeySelect";
            PubKeySelect.Size = new System.Drawing.Size(136, 23);
            PubKeySelect.TabIndex = 17;
            PubKeySelect.Text = "Wybierz plik...";
            PubKeySelect.UseVisualStyleBackColor = true;
            PubKeySelect.Click += PubKeyPath_Click;
            // 
            // PrivKeySelect
            // 
            PrivKeySelect.Location = new System.Drawing.Point(539, 247);
            PrivKeySelect.Name = "PrivKeySelect";
            PrivKeySelect.Size = new System.Drawing.Size(130, 23);
            PrivKeySelect.TabIndex = 18;
            PrivKeySelect.Text = "Wybierz plik...";
            PrivKeySelect.UseVisualStyleBackColor = true;
            PrivKeySelect.Click += PrivKeyPath_Click;
            // 
            // label5
            // 
            label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label5.Location = new System.Drawing.Point(12, 265);
            label5.MaximumSize = new System.Drawing.Size(0, 2);
            label5.MinimumSize = new System.Drawing.Size(0, 2);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 2);
            label5.TabIndex = 19;
            // 
            // PrivFilePath
            // 
            PrivFilePath.Location = new System.Drawing.Point(502, 135);
            PrivFilePath.Name = "PrivFilePath";
            PrivFilePath.Size = new System.Drawing.Size(204, 23);
            PrivFilePath.TabIndex = 20;
            // 
            // PrivFileSelect
            // 
            PrivFileSelect.AllowDrop = true;
            PrivFileSelect.Location = new System.Drawing.Point(539, 164);
            PrivFileSelect.Name = "PrivFileSelect";
            PrivFileSelect.Size = new System.Drawing.Size(108, 23);
            PrivFileSelect.TabIndex = 21;
            PrivFileSelect.Text = "Wybierz plik...";
            PrivFileSelect.UseVisualStyleBackColor = true;
            PrivFileSelect.Click += PrivFileSelect_Click;
            // 
            // label6
            // 
            label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label6.Location = new System.Drawing.Point(12, 288);
            label6.MaximumSize = new System.Drawing.Size(0, 2);
            label6.MinimumSize = new System.Drawing.Size(0, 2);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(0, 2);
            label6.TabIndex = 22;
            label6.Text = " ";
            // 
            // privpathholder
            // 
            privpathholder.Location = new System.Drawing.Point(458, 135);
            privpathholder.Name = "privpathholder";
            privpathholder.Size = new System.Drawing.Size(38, 23);
            privpathholder.TabIndex = 23;
            privpathholder.Visible = false;
            // 
            // pubpathholder
            // 
            pubpathholder.Location = new System.Drawing.Point(303, 135);
            pubpathholder.Name = "pubpathholder";
            pubpathholder.Size = new System.Drawing.Size(59, 23);
            pubpathholder.TabIndex = 24;
            pubpathholder.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSeaGreen;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pubpathholder);
            Controls.Add(privpathholder);
            Controls.Add(label6);
            Controls.Add(PrivFileSelect);
            Controls.Add(PrivFilePath);
            Controls.Add(label5);
            Controls.Add(PrivKeySelect);
            Controls.Add(PubKeySelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PrivKeyPath);
            Controls.Add(PubKeyPath);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PubFilePath);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            Controls.Add(PubFileSelect);
            Name = "Form1";
            Text = "deSZYfrator v0.5.1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        protected System.Windows.Forms.Button PubFileSelect;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox PubFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TextBox PubKeyPath;
        private System.Windows.Forms.TextBox PrivKeyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PubKeySelect;
        private System.Windows.Forms.Button PrivKeySelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrivFilePath;
        protected System.Windows.Forms.Button PrivFileSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox privpathholder;
        private System.Windows.Forms.TextBox pubpathholder;
    }
}

