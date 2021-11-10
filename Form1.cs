using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption;

namespace Cypher
{
    public partial class Form1 : Form
    {
        EncryptionLogic cypherLogic = new EncryptionLogic();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originalText = originalTextTextBox.Text;
            string keyText = keyTextBox.Text;
            string resultString = string.Empty;
            if (!decypherCheckBox.Checked)
            {
                resultString = cypherLogic.EncryptString(originalText,keyText);
            }
            else
            {
                resultString = cypherLogic.DecipherString(originalText,keyText);
            }
            resultTextBox.Text = resultString;
        }
        

        private void TextChange(object sender, EventArgs e)
        {
            encryptButton.Enabled = !(string.IsNullOrWhiteSpace(originalTextTextBox.Text) || string.IsNullOrWhiteSpace(keyTextBox.Text))
                & (keyTextBox.Text.Length == originalTextTextBox.Text.Length) & (BigInteger.TryParse(keyTextBox.Text, out BigInteger result));
            
                errorTextBox.Visible= encryptButton.Enabled ? false: true; 
           }
          
        }
    }

