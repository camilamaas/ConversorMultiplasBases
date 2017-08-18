namespace ConversorMultiplasBases
{
    partial class Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroConverter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaDecimal = new System.Windows.Forms.RadioButton();
            this.entradaHexadecimal = new System.Windows.Forms.RadioButton();
            this.entradaOctal = new System.Windows.Forms.RadioButton();
            this.entradaBinario = new System.Windows.Forms.RadioButton();
            this.botaoConverter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaValoresConvertidos = new System.Windows.Forms.ListBox();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a ser convertido:";
            // 
            // txtNumeroConverter
            // 
            this.txtNumeroConverter.Location = new System.Drawing.Point(203, 101);
            this.txtNumeroConverter.Name = "txtNumeroConverter";
            this.txtNumeroConverter.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroConverter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha a base binária do número inserido:";
            // 
            // entradaDecimal
            // 
            this.entradaDecimal.AutoSize = true;
            this.entradaDecimal.Location = new System.Drawing.Point(59, 172);
            this.entradaDecimal.Name = "entradaDecimal";
            this.entradaDecimal.Size = new System.Drawing.Size(63, 17);
            this.entradaDecimal.TabIndex = 3;
            this.entradaDecimal.TabStop = true;
            this.entradaDecimal.Text = "Decimal";
            this.entradaDecimal.UseVisualStyleBackColor = true;
            // 
            // entradaHexadecimal
            // 
            this.entradaHexadecimal.AutoSize = true;
            this.entradaHexadecimal.Location = new System.Drawing.Point(128, 172);
            this.entradaHexadecimal.Name = "entradaHexadecimal";
            this.entradaHexadecimal.Size = new System.Drawing.Size(86, 17);
            this.entradaHexadecimal.TabIndex = 4;
            this.entradaHexadecimal.TabStop = true;
            this.entradaHexadecimal.Text = "Hexadecimal";
            this.entradaHexadecimal.UseVisualStyleBackColor = true;
            // 
            // entradaOctal
            // 
            this.entradaOctal.AutoSize = true;
            this.entradaOctal.Location = new System.Drawing.Point(216, 172);
            this.entradaOctal.Name = "entradaOctal";
            this.entradaOctal.Size = new System.Drawing.Size(50, 17);
            this.entradaOctal.TabIndex = 5;
            this.entradaOctal.TabStop = true;
            this.entradaOctal.Text = "Octal";
            this.entradaOctal.UseVisualStyleBackColor = true;
            // 
            // entradaBinario
            // 
            this.entradaBinario.AutoSize = true;
            this.entradaBinario.Location = new System.Drawing.Point(272, 172);
            this.entradaBinario.Name = "entradaBinario";
            this.entradaBinario.Size = new System.Drawing.Size(57, 17);
            this.entradaBinario.TabIndex = 6;
            this.entradaBinario.TabStop = true;
            this.entradaBinario.Text = "Binário";
            this.entradaBinario.UseVisualStyleBackColor = true;
            // 
            // botaoConverter
            // 
            this.botaoConverter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botaoConverter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botaoConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConverter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.botaoConverter.Location = new System.Drawing.Point(106, 228);
            this.botaoConverter.Name = "botaoConverter";
            this.botaoConverter.Size = new System.Drawing.Size(157, 64);
            this.botaoConverter.TabIndex = 7;
            this.botaoConverter.Text = "Converter";
            this.botaoConverter.UseVisualStyleBackColor = false;
            this.botaoConverter.Click += new System.EventHandler(this.botaoConverter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // listaValoresConvertidos
            // 
            this.listaValoresConvertidos.FormattingEnabled = true;
            this.listaValoresConvertidos.Location = new System.Drawing.Point(26, 323);
            this.listaValoresConvertidos.Name = "listaValoresConvertidos";
            this.listaValoresConvertidos.Size = new System.Drawing.Size(342, 95);
            this.listaValoresConvertidos.TabIndex = 9;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.Location = new System.Drawing.Point(306, 291);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(63, 26);
            this.botaoLimpar.TabIndex = 10;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conversor de bases binárias";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(400, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.listaValoresConvertidos);
            this.Controls.Add(this.botaoConverter);
            this.Controls.Add(this.entradaBinario);
            this.Controls.Add(this.entradaOctal);
            this.Controls.Add(this.entradaHexadecimal);
            this.Controls.Add(this.entradaDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroConverter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Conversor";
            this.Text = "Conversor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton entradaDecimal;
        private System.Windows.Forms.RadioButton entradaHexadecimal;
        private System.Windows.Forms.RadioButton entradaOctal;
        private System.Windows.Forms.RadioButton entradaBinario;
        private System.Windows.Forms.Button botaoConverter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listaValoresConvertidos;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

