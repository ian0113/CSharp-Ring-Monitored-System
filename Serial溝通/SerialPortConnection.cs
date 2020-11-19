using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

public class SerialPortConnection
{
    public SerialPort SerialPort
    {
        get => _serialPort;
    }
    private SerialPort _serialPort;

    public SerialPortConnection(string serialPortName)
    {
        _serialPort = new SerialPort();
        _serialPort.BaudRate = 9600;
        _serialPort.PortName = serialPortName;
        _serialPort.ReadTimeout = 1;
    }
    /// <summary>
    /// 嘗試連接SerialPort
    /// 連接成功回true
    /// </summary>
    /// <returns>回傳成功與否</returns>
    public bool Connect()
    {
        try
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
                _serialPort.DiscardInBuffer();
            }
            else
                return false;
            return true;
        }
        catch (System.UnauthorizedAccessException)
        {
            // 重複連接
            return false;
        }
        catch (Exception e)
        {

            Console.WriteLine("SerialPortConnection.Connect ->" + e);
            return false;
        }
    }

    /// <summary>
    /// 嘗試斷開與SerialPort連接
    /// 斷開成功為true
    /// </summary>
    /// <returns>回傳成功與否</returns>
    public bool DisConnect()
    {
        try
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
            else
                return false;
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("SerialPortConnection.DisConnect ->" + e);
            return false;
        }
    }

    /// <summary>
    /// 對SerialPort寫入一行訊息(包含換行符號)
    /// </summary>
    /// <param name="s">訊息</param>
    public void Write(string s)
    {
        try
        {
            _serialPort.Write(s);
        }
        catch (Exception e)
        {
            Console.WriteLine("SerialPortConnection.Write ->" + e);
        }
    }

    /// <summary>
    /// 從SerialPort讀取一行訊息
    /// 並將空白及換行符號去除
    /// </summary>
    /// <returns>回傳訊息</returns>
    public string Read()
    {
        try
        {
            string msg = _serialPort.ReadLine();
            msg = msg.Trim().TrimEnd( '\n', '\r', ' ', '\0',(char)32);
            return msg;
        }
        catch (System.TimeoutException)
        {
            // 作業逾時

            return "";
        }
        catch (Exception e)
        {
            Console.WriteLine("SerialPortConnection.Read ->" + e);
            return "";
        }
    }
}

