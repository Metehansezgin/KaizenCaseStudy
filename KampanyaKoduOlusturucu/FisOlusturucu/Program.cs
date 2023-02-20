using FisOlusturucu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FisOlusturucu
{
    public class Program
    {
        static void Main(string[] args)
        {
            string json = System.IO.File.ReadAllText(@"../../../response.json");
            List<FisIcerik> fisIcerik = JsonConvert.DeserializeObject<List<FisIcerik>>(json);
       
            //for (int i = 1; i < fisIcerik.Count; i++)
            //{
            //    Console.SetCursorPosition(fisIcerik[i].boundingPoly.vertices[0].x-30, fisIcerik[i].boundingPoly.vertices[0].y-88);
            //    Console.Write(fisIcerik[i].description);
            //}
        }
    }
}
