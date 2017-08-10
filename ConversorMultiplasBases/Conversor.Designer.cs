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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroConverter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaDecimal = new System.Windows.Forms.RadioButton();
            this.entradaHexadeciaml = new System.Windows.Forms.RadioButton();
            this.entradaOctal = new System.Windows.Forms.RadioButton();
            this.entradaBinario = new System.Windows.Forms.RadioButton();
            this.botaoConverter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a ser convertido:";
            // 
            // txtNumeroConverter
            // 
            this.txtNumeroConverter.Location = new System.Drawing.Point(181, 35);
            this.txtNumeroConverter.Name = "txtNumeroConverter";
            this.txtNumeroConverter.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroConverter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha a base binária do número inserido:";
            // 
            // entradaDecimal
            // 
            this.entradaDecimal.AutoSize = true;
            this.entradaDecimal.Location = new System.Drawing.Point(37, 106);
            this.entradaDecimal.Name = "entradaDecimal";
            this.entradaDecimal.Size = new System.Drawing.Size(63, 17);
            this.entradaDecimal.TabIndex = 3;
            this.entradaDecimal.TabStop = true;
            this.entradaDecimal.Text = "Decimal";
            this.entradaDecimal.UseVisualStyleBackColor = true;
            // 
            // entradaHexadeciaml
            // 
            this.entradaHexadeciaml.AutoSize = true;
            this.entradaHexadeciaml.Location = new System.Drawing.Point(106, 106);
            this.entradaHexadeciaml.Name = "entradaHexadeciaml";
            this.entradaHexadeciaml.Size = new System.Drawing.Size(86, 17);
            this.entradaHexadeciaml.TabIndex = 4;
            this.entradaHexadeciaml.TabStop = true;
            this.entradaHexadeciaml.Text = "Hexadecimal";
            this.entradaHexadeciaml.UseVisualStyleBackColor = true;
            // 
            // entradaOctal
            // 
            this.entradaOctal.AutoSize = true;
            this.entradaOctal.Location = new System.Drawing.Point(194, 106);
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
            this.entradaBinario.Location = new System.Drawing.Point(250, 106);
            this.entradaBinario.Name = "entradaBinario";
            this.entradaBinario.Size = new System.Drawing.Size(57, 17);
            this.entradaBinario.TabIndex = 6;
            this.entradaBinario.TabStop = true;
            this.entradaBinario.Text = "Binário";
            this.entradaBinario.UseVisualStyleBackColor = true;
            // 
            // botaoConverter
            // 
            this.botaoConverter.Location = new System.Drawing.Point(106, 161);
            this.botaoConverter.Name = "botaoConverter";
            this.botaoConverter.Size = new System.Drawing.Size(130, 42);
            this.botaoConverter.TabIndex = 7;
            this.botaoConverter.Text = "Converter";
            this.botaoConverter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 231);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 95);
            this.listBox1.TabIndex = 9;
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 358);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.botaoConverter);
            this.Controls.Add(this.entradaBinario);
            this.Controls.Add(this.entradaOctal);
            this.Controls.Add(this.entradaHexadeciaml);
            this.Controls.Add(this.entradaDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroConverter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Conversor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton entradaDecimal;
        private System.Windows.Forms.RadioButton entradaHexadeciaml;
        private System.Windows.Forms.RadioButton entradaOctal;
        private System.Windows.Forms.RadioButton entradaBinario;
        private System.Windows.Forms.Button botaoConverter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

