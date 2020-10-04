// Using Class Libraries
using FileShareData;

// Using System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;



namespace FileSend
{
    public class FileSendLogic
    {
        // Send File
        public async Task SendFile()
        {
            // Variables
            var FilePath = FileShareDataModel.FilePath;
            var SendIPAddress = FileShareDataModel.SendIPAddress;
            var SendPort = FileShareDataModel.SendPort;
            var SendBufferSize = FileShareDataModel.SendBufferSize;

            //// Get File Size
            //FileInfo fi = new FileInfo(FilePath);
            //long FileSize = fi.Length;

            // Establish Socket Endpoint
            IPAddress ipAddress = Dns.GetHostAddresses(SendIPAddress)[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, SendPort);

            // Create Socket
            Socket ClientSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Try to Connect Socket
            try
            {
                // Connect Socket to Remote Endpoint
                await Task.Run(() => ClientSocket.Connect(ipEndPoint));
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException : {0}", e.ToString());
            }

            // Prepare File
            FileStream ClientFS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            byte[] FileBytes = File.ReadAllBytes(FilePath);
            ClientFS.Close();

            byte[] FileData = new byte[4096];
            byte[] FileSize = BitConverter.GetBytes(FileBytes.Length);

            // Send File Size to Endpoint
            ClientSocket.Send(FileSize, FileSize.Length, SocketFlags.None);

            // Send Data

            //// Try to Connect Socket
            //try
            //{
            //    // Connect Socket to Remote Endpoint
            //    await Task.Run(() => ClientSocket.Connect(ipEndPoint));

            //    // Send File Size
            //    byte[] EncodedFileSize = Encoding.UTF8.GetBytes(FileSize.ToString());
            //    int byteSent = ClientSocket.Send(EncodedFileSize);

            //    // Create File Stream
            //    using (FileStream ClientFS = new FileStream(FilePath, FileMode.Open))
            //    {
            //        byte[] bytes = new byte[SendBufferSize];
            //    }

            //}

            //// Catch Socket Exceptions
            //catch (ArgumentNullException e)
            //{
            //    Console.WriteLine("ArgumentNullException : {0}", e.ToString());
            //}
            //catch (SocketException e)
            //{

            //    Console.WriteLine("SocketException : {0}", e.ToString());
            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine("Unexpected exception : {0}", e.ToString());
            //}
        }
    }
}
