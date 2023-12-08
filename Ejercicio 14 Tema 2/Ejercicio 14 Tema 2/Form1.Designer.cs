namespace Ejercicio_14_Tema_2
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
            this.BotonMayor = new System.Windows.Forms.Button();
            this.BotonMenor = new System.Windows.Forms.Button();
            this.BotonIgual = new System.Windows.Forms.Button();
            this.BotonDistinto = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.TrueFalseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonMayor
            // 
            this.BotonMayor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonMayor.Location = new System.Drawing.Point(146, 139);
            this.BotonMayor.Name = "BotonMayor";
            this.BotonMayor.Size = new System.Drawing.Size(65, 59);
            this.BotonMayor.TabIndex = 0;
            this.BotonMayor.Text = ">";
            this.BotonMayor.UseVisualStyleBackColor = true;
            this.BotonMayor.Click += new System.EventHandler(this.BotonMayor_Click);
            // 
            // BotonMenor
            // 
            this.BotonMenor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonMenor.Location = new System.Drawing.Point(290, 139);
            this.BotonMenor.Name = "BotonMenor";
            this.BotonMenor.Size = new System.Drawing.Size(63, 59);
            this.BotonMenor.TabIndex = 1;
            this.BotonMenor.Text = "<";
            this.BotonMenor.UseVisualStyleBackColor = true;
            this.BotonMenor.Click += new System.EventHandler(this.BotonMenor_Click);
            // 
            // BotonIgual
            // 
            this.BotonIgual.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonIgual.Location = new System.Drawing.Point(428, 139);
            this.BotonIgual.Name = "BotonIgual";
            this.BotonIgual.Size = new System.Drawing.Size(66, 59);
            this.BotonIgual.TabIndex = 2;
            this.BotonIgual.Text = "==";
            this.BotonIgual.UseVisualStyleBackColor = true;
            this.BotonIgual.Click += new System.EventHandler(this.BotonIgual_Click);
            // 
            // BotonDistinto
            // 
            this.BotonDistinto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonDistinto.Location = new System.Drawing.Point(576, 139);
            this.BotonDistinto.Name = "BotonDistinto";
            this.BotonDistinto.Size = new System.Drawing.Size(64, 59);
            this.BotonDistinto.TabIndex = 3;
            this.BotonDistinto.Text = "!=";
            this.BotonDistinto.UseVisualStyleBackColor = true;
            this.BotonDistinto.Click += new System.EventHandler(this.BotonDistinto_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.Location = new System.Drawing.Point(301, 64);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(193, 28);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.Location = new System.Drawing.Point(301, 237);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(193, 28);
            this.txtNum2.TabIndex = 5;
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num1Label.Location = new System.Drawing.Point(185, 70);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(102, 21);
            this.Num1Label.TabIndex = 6;
            this.Num1Label.Text = "Número 1:";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num2Label.Location = new System.Drawing.Point(185, 243);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(102, 21);
            this.Num2Label.TabIndex = 7;
            this.Num2Label.Text = "Número 2:";
            // 
            // TrueFalseLabel
            // 
            this.TrueFalseLabel.AutoSize = true;
            this.TrueFalseLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrueFalseLabel.Location = new System.Drawing.Point(360, 313);
            this.TrueFalseLabel.Name = "TrueFalseLabel";
            this.TrueFalseLabel.Size = new System.Drawing.Size(0, 21);
            this.TrueFalseLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrueFalseLabel);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.BotonDistinto);
            this.Controls.Add(this.BotonIgual);
            this.Controls.Add(this.BotonMenor);
            this.Controls.Add(this.BotonMayor);
            this.Name = "Form1";
            this.Text = "Ejercicio 14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotonMayor;
        private Button BotonMenor;
        private Button BotonIgual;
        private Button BotonDistinto;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label Num1Label;
        private Label Num2Label;
        private Label TrueFalseLabel;
    }
}