using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        for(int idx=0; idx<input.Length; idx++)
        {
            string n=input[idx];
            if(n.Length == 13)
            {
                if(n[0]=='+' && n[1]=='3' && n[2]=='9')
                {
                    return n;
                }
            }
            else
            {
                if(n.Length==14)
                {
                    if(n[0]== '0' && n[1]== '0' && n[2] == '3' && n[3]== '9')
                    {
                        return n;
                    }
                }
                else
                {
                    if(n.Length==10)
                    {
                        if(n[0]==3)
                        {
                            return "";
                        }
                    }
                }
            }
            

        }
        
        
        return "";
    }
}