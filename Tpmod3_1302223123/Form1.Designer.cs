namespace Tpmod3_1302223123
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextbox = new System.Windows.Forms.Label();
            this.ButtonKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.Location = new System.Drawing.Point(555, 115);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(171, 56);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputTextbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(97, 115);
            this.inputTextbox.Multiline = true;
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(401, 56);
            this.inputTextbox.TabIndex = 1;
            this.inputTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // outputTextbox
            // 
            this.outputTextbox.AutoSize = true;
            this.outputTextbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputTextbox.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextbox.Location = new System.Drawing.Point(111, 216);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(144, 33);
            this.outputTextbox.TabIndex = 3;
            this.outputTextbox.Text = "OUTPUT";
            this.outputTextbox.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButtonKeluar
            // 
            this.ButtonKeluar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonKeluar.Location = new System.Drawing.Point(555, 188);
            this.ButtonKeluar.Name = "ButtonKeluar";
            this.ButtonKeluar.Size = new System.Drawing.Size(171, 61);
            this.ButtonKeluar.TabIndex = 4;
            this.ButtonKeluar.Text = "keluar";
            this.ButtonKeluar.UseVisualStyleBackColor = false;
            this.ButtonKeluar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonKeluar);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputTextbox;
        private System.Windows.Forms.Button ButtonKeluar;
    }
}

