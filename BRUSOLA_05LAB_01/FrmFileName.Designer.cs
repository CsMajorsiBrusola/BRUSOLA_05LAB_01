namespace BRUSOLA_05LAB_01
{
    partial class FrmFileName
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
            Okay = new Button();
            FileName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Okay
            // 
            Okay.Location = new Point(104, 126);
            Okay.Name = "Okay";
            Okay.Size = new Size(183, 33);
            Okay.TabIndex = 0;
            Okay.Text = "Okay";
            Okay.UseVisualStyleBackColor = true;
            Okay.Click += Okay_Click_Click;
            // 
            // FileName
            // 
            FileName.BorderStyle = BorderStyle.FixedSingle;
            FileName.Location = new Point(70, 78);
            FileName.Name = "FileName";
            FileName.Size = new Size(257, 23);
            FileName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter File Name:";
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 181);
            Controls.Add(label1);
            Controls.Add(FileName);
            Controls.Add(Okay);
            Name = "FrmFileName";
            Text = "FrmFileName";
            Load += FrmFileName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Okay;
        private TextBox FileName;
        private Label label1;
    }
}