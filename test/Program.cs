// See https://aka.ms/new-console-template for more information
using System.IO;
using System;
using System.Text;
using System.Drawing.Drawing2D;
using System.Data;
using System.Collections.Generic;

namespace file
{
  class Program{

    static void Main(string[] args){

      string DxfFile = args[1]
      string csvFile = "output.csv";

      List<string> lines = new List<string>();
      List<string> lines2 = new List<string>();
      lines2.Add("y,x,z");
      lines = File.ReadAllLines(DxfFile).ToList();
      int size = lines.Count();
      for(int i=0; i<size; i++){
          if(lines[i] == "AcDb3dPolylineVertex"){
              if(lines[i+6] != "-999.0"){
                string xyz = lines[i+4] + ","+lines[i+2] +"," + lines[i+6];
                lines2.Add(xyz);
                File.WriteAllLines(csvFile, lines2);
              }
          }
      }
    }
  }
}
 

