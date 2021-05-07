using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    public class AnalyzerBackWork
    {
        public static char[] Token =  new Char[500];
        public static string[] keyWords = new String[] { "cout", "cin", "if", "else", "for", "while", "void", "int", "float", "char", "double" };

        public static string[] keywordsArray = new String[25];
        public static int keywordsCount = 0;

        public static string[] operators  = new String[25];
        public static int operatorCount = 0;

        public static string[] libraries = new String[25];
        public static int librariesCount = 0;

        public static char[] variables = new Char[500];
        public static string[] originalVariables = new String[25];
        public static int varCount = 0;

        public static int index = 0;
        public static int cnt = 0;
        
        public static string fileN;
  
        public static string readFullFile(String fileName)
        {
            try
            {
                TextReader tr = File.OpenText(fileName);

                return tr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static void ReadFile()
        {
            try
            {
                TextReader tr = File.OpenText(fileN);
                string line = tr.ReadLine();

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        Token[index++] = line[i];
                    }

                    line = tr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static String charArrayToString(char[] tempStr)
        {
            string merged = "";

            foreach (char str in tempStr)
            {
                merged += str;
            }

            return merged;
        }

        public static void extractKeyWords(String toSearch) // search reserve words
        {
            for (int i = 0; i < keyWords.Length; i++)
            {
                if (keyWords[i].Equals(toSearch))
                {
                    keywordsArray[keywordsCount++] = toSearch; // KEYWORDS STORAGE                   
                }
            }            
        }

        public static void extractVariablesAndDataTypes(Char[] word)
        {
            extractKeyWords(charArrayToString(word)); 

            char[] varArr = new Char[500];
            int varCounter = 0;

            if (string.Compare(charArrayToString(word), "int") == 0 ||
                string.Compare(charArrayToString(word), "char") == 0 ||
                string.Compare(charArrayToString(word), "float") == 0 ||
                string.Compare(charArrayToString(word), "double") == 0)
            {
                while (Token[cnt] != ';')
                    varArr[varCounter++] = Token[cnt++];
                
                char[] tempVariable = new Char[varCounter];
                
                for (int a = 0; a < varCounter; a++)
                    tempVariable[a] = varArr[a];

                for (int v = 0; v < varCounter; v++)
                {
                    if (tempVariable[v] == ',')
                    {
                        variables[varCount] = ' ';                        
                        varCount = varCount + 1;
                    }
                    else if (tempVariable[v] == '=')
                    {
                        while (tempVariable[v] != ',' && v < varCounter - 1)
                        {
                            v = v + 1;
                        }

                        variables[varCount] = ' ';
                        varCount = varCount + 1;
                    }
                    else
                    {
                        variables[varCount] = tempVariable[v];
                        varCount = varCount + 1;
                    }
                }

                originalVariables = charArrayToString(variables).Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                
                for (int b = 0; b < varCounter; b++)
                {
                    varArr[b] = ' ';
                }

                varCounter = 0;
            }            
        }
     
        public static void myMain()
        {            
            char[] word = new Char[500];
            int counter = 0;
            char[] lib = new Char[500];
            int libCounter = 0;

            ReadFile();

            for (cnt = 0; cnt < index; cnt++)
            {
                // FOR CHECKING OPERATORS

                if (Token[cnt] == '+' || Token[cnt] == '-' || Token[cnt] == '*' || Token[cnt] == '/' || Token[cnt] == '%' || Token[cnt] == '&' || Token[cnt] == '^'
                    || Token[cnt] == '<' || Token[cnt] == '>' || Token[cnt] == '!' || Token[cnt] == '=')
                {
                    if (Token[cnt] == '+')
                    {
                        if (Token[cnt + 1] == '+')
                            operators[operatorCount++] = Token[cnt] + "" + Token[cnt + 1];
                        else
                            operators[operatorCount++] = Token[cnt].ToString();
                    }
                    else if (Token[cnt] == '-')
                    {
                        if (Token[cnt + 1] == '-')
                            operators[operatorCount++] = Token[cnt] + "" + Token[cnt + 1];
                        else
                            operators[operatorCount++] = Token[cnt].ToString();
                    }
                    else if (Token[cnt] == '<')
                    {
                        if (Token[cnt + 1] == '=')
                            operators[operatorCount++] = Token[cnt] + "" + Token[cnt + 1];
                        else
                            operators[operatorCount++] = Token[cnt].ToString();
                    }
                    else if (Token[cnt] == '>')
                    {
                        if (Token[cnt + 1] == '=')
                            operators[operatorCount++] = Token[cnt] + "" + Token[cnt + 1];
                        else
                            operators[operatorCount++] = Token[cnt].ToString();
                    }
                    else if (Token[cnt] == '!')
                    {
                        if (Token[cnt + 1] == '=')
                            operators[operatorCount++] = Token[cnt] + "" + Token[cnt + 1];
                        else
                            operators[operatorCount++] = Token[cnt].ToString();
                    }
                    else if (Token[cnt] == '=')
                    {
                        if (Token[cnt + 1] == '=')
                            operators[operatorCount++] = Token[cnt] + "" + Token[cnt + 1];
                        else
                            operators[operatorCount++] = Token[cnt].ToString();
                    }
                    else
                        operators[operatorCount++] = Token[cnt].ToString();
                }

                // FOR CHECKING LIBRARIES

                if (Token[cnt] == '#')
                {
                    while (Token[cnt] != '>')
                        lib[libCounter++] = Token[cnt++];

                    lib[libCounter++] = Token[cnt];

                    char[] tempLib = new Char[libCounter];
                    
                    for (int a = 0; a < libCounter; a++)
                        tempLib[a] = lib[a];

                    libraries[librariesCount++] = charArrayToString(tempLib); // LIBRARIES STORAGE

                    for (int b = 0; b < libCounter; b++)
                    {
                        lib[b] = ' ';
                    }
                    libCounter = 0;
                }

                // FOR CHECKING REST

                if (Token[cnt] == ' ' || Token[cnt] == '(' || Token[cnt] == '{' || Token[cnt] == ',' || Token[cnt] == '<' || Token[cnt] == '>' || Token[cnt] == ';' || Token[cnt] == '}' || Token[cnt] == ')')
                {
                    word[counter] = '\0';
                    
                    char[] tempWord = new Char[counter];    
                
                    for (int a = 0; a < counter; a++)
                        tempWord[a] = word[a];

                    extractVariablesAndDataTypes(tempWord); // FUNCTION That extracts variables and datatypes

                    for (int j = 0; j < counter; j++)
                        word[j] = ' ';
                    
                    counter = 0;
                }
                else
                {
                    word[counter++] = Token[cnt];
                }
            } 
        }
    }
}
