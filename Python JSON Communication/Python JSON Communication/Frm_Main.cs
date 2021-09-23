using System;
using System.Windows.Forms;

namespace Python_JSON_Communication
{
    public partial class Frm_Main : Form
    {
        CPythonCommunication PythonCom = new CPythonCommunication( );

        public Frm_Main( )
        {
            InitializeComponent( );
        }

        private void Btn_SendMessage_Click( object sender, EventArgs e )
        {
            try
            {
                if ( string.IsNullOrEmpty( TxtBx_Message.Text ) )
                {
                    MessageBox.Show( "No es posible no enviar nada", "Campos vacios" );
                    return;
                }
                PythonCom.SendMessage( TxtBx_Message.Text );

                if ( !Tmr_CheckFile.Enabled )
                    Tmr_CheckFile.Enabled = true;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void Tmr_CheckFile_Tick( object sender, EventArgs e )
        {
            try
            {
                TxtBx_MessageReceived.Text = PythonCom.ReadMessage( );
            }
            catch ( Exception ex )
            {
                Tmr_CheckFile.Enabled = false;

                MessageBox.Show( ex.Message, "Error al leer mensaje de Python" );
            }
        }
    }
}
