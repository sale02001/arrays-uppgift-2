using System;

class MainClass {
  public static void Main (string[] args) {
    
    double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
    
    double sum = 0;
    for (int i = 0; i<temperatur.Length; i++)
    sum = sum + temperatur[i];
  
    Console.WriteLine("medeltempetatur är: " + sum / temperatur.Length);
     
  }
}