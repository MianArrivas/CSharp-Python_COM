using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Collections.Generic;

namespace Python_JSON_Communication
{
    public class CPythonCommunication
    {
        private const string SEND_FILE = @".\MessageFromCSharp.json";
        private const string RECEIVED_FILE = @".\MessageFromCSharp.json";   //MessageFromPython.json

        private string sReadMessage;

        private string GetMessageFromPython { get { return sReadMessage; } }


        private void CreateJsonSendFile(string Message )
        {
            if ( File.Exists( SEND_FILE ) )
                File.Delete( SEND_FILE );

            using( FileStream fs = File.Create(SEND_FILE) )
            {
                byte[ ] bymessage = new UTF8Encoding( true ).GetBytes( Message );

                fs.Write( bymessage, 0, bymessage.Length );
            }
        }

        public void SendMessage(string Message )
        {
            CJsonMessage message = new CJsonMessage( Message );

            string sjsonString = JsonConvert.SerializeObject( message );

            try
            {
                Console.WriteLine( sjsonString );

                CreateJsonSendFile( sjsonString );
            }
            catch ( Exception ex )
            {
                throw new Exception( "It was not possible to create file.\n" + ex.Message );
            }
        }

        public string ReadMessage( )
        {
            try
            {
                if ( !File.Exists( RECEIVED_FILE ) )
                    return null;

                CJsonMessage message = new CJsonMessage( );

                string smessage, sjsonMessage = "";

                using ( StreamReader sr = File.OpenText( RECEIVED_FILE ) )
                {
                    while ( ( smessage = sr.ReadLine( ) ) != null )
                        sjsonMessage += smessage;
                }

                JObject pythonMessage = JObject.Parse( sjsonMessage );

                sReadMessage = pythonMessage[ "Message" ].ToString( );
            }
            catch ( Exception ex )
            {
                throw new Exception( "It was not possible to read file from Python, is it created?\n" + ex.Message );
            }

            return sReadMessage;
        }
    }
}
