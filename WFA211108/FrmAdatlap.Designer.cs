
namespace WFA211108
{
    partial class FrmAdatlap
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTulajdonosok = new System.Windows.Forms.ComboBox();
            this.nudSuly = new System.Windows.Forms.NumericUpDown();
            this.rbKanca = new System.Windows.Forms.RadioButton();
            this.pbFajta = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCsodor = new System.Windows.Forms.RadioButton();
            this.cbFajtak = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFajta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajta:";
            // 
            // cbTulajdonosok
            // 
            this.cbTulajdonosok.BackColor = System.Drawing.Color.Plum;
            this.cbTulajdonosok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTulajdonosok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTulajdonosok.FormattingEnabled = true;
            this.cbTulajdonosok.Location = new System.Drawing.Point(176, 126);
            this.cbTulajdonosok.Name = "cbTulajdonosok";
            this.cbTulajdonosok.Size = new System.Drawing.Size(151, 28);
            this.cbTulajdonosok.TabIndex = 1;
            this.cbTulajdonosok.SelectedIndexChanged += new System.EventHandler(this.CbTulajdonosok_SelectedIndexChanged);
            // 
            // nudSuly
            // 
            this.nudSuly.BackColor = System.Drawing.Color.Plum;
            this.nudSuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudSuly.Location = new System.Drawing.Point(176, 181);
            this.nudSuly.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.nudSuly.Name = "nudSuly";
            this.nudSuly.Size = new System.Drawing.Size(151, 26);
            this.nudSuly.TabIndex = 2;
            this.nudSuly.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // rbKanca
            // 
            this.rbKanca.AutoSize = true;
            this.rbKanca.BackColor = System.Drawing.Color.Plum;
            this.rbKanca.Checked = true;
            this.rbKanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbKanca.Location = new System.Drawing.Point(176, 235);
            this.rbKanca.Name = "rbKanca";
            this.rbKanca.Size = new System.Drawing.Size(70, 24);
            this.rbKanca.TabIndex = 3;
            this.rbKanca.TabStop = true;
            this.rbKanca.Text = "kanca";
            this.rbKanca.UseVisualStyleBackColor = false;
            // 
            // pbFajta
            // 
            this.pbFajta.BackColor = System.Drawing.Color.Plum;
            this.pbFajta.Location = new System.Drawing.Point(354, 41);
            this.pbFajta.Name = "pbFajta";
            this.pbFajta.Size = new System.Drawing.Size(200, 250);
            this.pbFajta.TabIndex = 4;
            this.pbFajta.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tulajdonos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(53, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(53, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nem:";
            // 
            // rbCsodor
            // 
            this.rbCsodor.AutoSize = true;
            this.rbCsodor.BackColor = System.Drawing.Color.Plum;
            this.rbCsodor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbCsodor.Location = new System.Drawing.Point(252, 235);
            this.rbCsodor.Name = "rbCsodor";
            this.rbCsodor.Size = new System.Drawing.Size(75, 24);
            this.rbCsodor.TabIndex = 3;
            this.rbCsodor.Text = "csődör";
            this.rbCsodor.UseVisualStyleBackColor = false;
            // 
            // cbFajtak
            // 
            this.cbFajtak.BackColor = System.Drawing.Color.Plum;
            this.cbFajtak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFajtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFajtak.FormattingEnabled = true;
            this.cbFajtak.Location = new System.Drawing.Point(176, 72);
            this.cbFajtak.Name = "cbFajtak";
            this.cbFajtak.Size = new System.Drawing.Size(151, 28);
            this.cbFajtak.TabIndex = 1;
            this.cbFajtak.SelectedIndexChanged += new System.EventHandler(this.CbFajtak_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Plum;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInsert.Location = new System.Drawing.Point(57, 326);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(497, 61);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Új egyed rögzítése az adatbázisba!";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // FrmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(604, 424);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pbFajta);
            this.Controls.Add(this.rbCsodor);
            this.Controls.Add(this.rbKanca);
            this.Controls.Add(this.nudSuly);
            this.Controls.Add(this.cbFajtak);
            this.Controls.Add(this.cbTulajdonosok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdatlap";
            this.Text = "Új egyed bejelentése";
            this.Load += new System.EventHandler(this.FrmAdatlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFajta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTulajdonosok;
        private System.Windows.Forms.NumericUpDown nudSuly;
        private System.Windows.Forms.RadioButton rbKanca;
        private System.Windows.Forms.PictureBox pbFajta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCsodor;
        private System.Windows.Forms.ComboBox cbFajtak;
        private System.Windows.Forms.Button btnInsert;
    }
}