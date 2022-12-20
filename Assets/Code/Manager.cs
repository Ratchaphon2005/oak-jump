using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class Manager : MonoBehaviour
{
    Thread receiveThread;
    UdpClient client; 
    public int port = 1234;
    private string data;
    private bool jump; 
    public void Start()
    {
        receiveThread = new Thread(
            new ThreadStart(receiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
        
    }
    private void receiveData()
    {
        
        client = new UdpClient(port);
        while (true)
        {
            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] dataByte = client.Receive(ref anyIP);
                data = Encoding.UTF8.GetString(dataByte);

                if (data == "true") { 
                    this.jump = true;
                }

            }
            catch (Exception err)
            {
                print(err.ToString());
            }
        }
    }
    public bool getJump(){
        return this.jump;
    }
    public void setJump(bool jump){
        this.jump = jump;
    }
}
