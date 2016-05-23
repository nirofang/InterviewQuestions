using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ansi2unicode
{
    class ansi2unicode
    {
        static void Main(string[] args)
        {

            //Declare Class to Work in all the program
            ansi2unicode prgConvert = new ansi2unicode();

            //Verify arguments
            if (args.Length == 0)
            {

                //Show Help of the parameters
                prgConvert.showHelp();
                return;

            }

            // Start the work
            try
            {

                //Create variable to count arguments
                int arguments = 0;

                //Declare flag to parameters without text
                bool flgRecursible = false;

                //Create variable to save parameter with text
                String input = "";
                String output = "";
                String directory = "";
                String filter = "*.*";

                //Verify informed parameters
                while (arguments < args.Length)
                {

                    //Case argument is help argument
                    if (args[arguments].Substring(0, 2) == "-h")
                    {

                        //Show Help of the parameters
                        prgConvert.showHelp();
                        return;

                    }

                    //Case argument is help argument
                    if (args[arguments].Substring(0, 2) == "-R")
                    {

                        //Show Help of the parameters
                        flgRecursible = true;

                    }

                    //Case argument is input argument
                    if (args[arguments].Substring(0, 2) == "-i")
                    {

                        //Verify length of arguments
                        if (args.Length >= (arguments + 2))
                        {

                            //Verify if next argument don´t start with "-"
                            if (args[arguments + 1].Substring(0, 1) != "-")
                            {

                                //Receive the arguments from console
                                //input = Environment.CurrentDirectory + "/" + args[arguments + 1];
                                input = args[arguments + 1];
                            }

                        }

                    }

                    //Case argument is output argument
                    if (args[arguments].Substring(0, 2) == "-o")
                    {

                        //Verify length of arguments
                        if (args.Length >= (arguments + 2))
                        {

                            //Verify if next argument don´t start with "-"
                            if (args[arguments + 1].Substring(0, 1) != "-")
                            {

                                //Receive the arguments from console
                                //output = Environment.CurrentDirectory + "/" + args[arguments + 1];
                                output = args[arguments + 1];

                            }

                        }

                    }

                    //Case argument is Directory argument
                    if (args[arguments].Substring(0, 2) == "-d")
                    {

                        //Verify length of arguments
                        if (args.Length >= (arguments + 2))
                        {

                            //Verify if next argument don´t start with "-"
                            if (args[arguments + 1].Substring(0, 1) != "-")
                            {

                                //Receive the arguments from console
                                directory = args[arguments + 1];

                            }

                        }

                    }

                    //Case argument is Directory argument
                    if (args[arguments].Substring(0, 2) == "-f")
                    {

                        //Verify length of arguments
                        if (args.Length >= (arguments + 2))
                        {

                            //Verify if next argument don´t start with "-"
                            if (args[arguments + 1].Substring(0, 1) != "-")
                            {

                                //Receive the arguments from console
                                filter = args[arguments + 1];

                            }

                        }

                    }

                    // Sum a counter to exit a loop
                    arguments++;

                }

                // verify
                if (directory.Length == 0 & input.Length > 0 & output.Length > 0)
                {

                    //Call function to convert a file
                    prgConvert.convertFile2Unicode(input, output);

                }
                else if (directory.Length > 0)
                {

                    //Call function to directory
                    prgConvert.convertWithRecursion(directory, flgRecursible, filter);

                }
                else
                {

                    //Show error message
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Please use a correct sentences. See the examples.txt for more examples.");
                    System.Console.WriteLine("");

                }

            }
            catch (InvalidCastException e)
            {

                //If occour a error, show a menssage
                System.Console.WriteLine("MSG: Error found when execute the program, please send mail to rsartorelli@directtalk.com.br");
                throw (e);

            }

        }

        private void convertFile2Unicode(String inputFile, String outputFile)
        {

            // Start the work
            try
            {

                //Open the input file to be read
                Stream se = File.OpenRead(inputFile);

                //Declare the file buffer length
                int tamanhoBuffer = (int)(se.Length * 2);

                //Declare the buffer byte variable
                byte[] buffer = new Byte[tamanhoBuffer];
                //Declare a char to be read from the input file
                char[] digito = new Char[] { 'a' };
                //String to save the conversion
                StringBuilder arquivoSaida = new StringBuilder();

                //Escreve no arquivo enquanto houver bytes no buffer a serem escritos 
                while ((se.Read(buffer, 0, buffer.Length)) > 0)
                {
                    //Recebe o caractere referente ao dígito do Buffer
                    //digito = Encoding.Default.GetChars(buffer);
                    digito = Encoding.GetEncoding("GBK").GetChars(buffer);

                    //Adiciona o dígito ao texto informado
                    arquivoSaida.Append(digito);
                }

                //Fecha o arquivo de Origem para que possa ser trabalhado o arquivo de Destino
                se.Close();

                // Prepara o arquivo de Destino
                Stream ss = File.OpenWrite(outputFile);
                // Prepara o arquivo de Destino para trabalhar em Unicode
                StreamWriter streamUnicode = new StreamWriter(ss, Encoding.Unicode);

                //Grava o arquivo final em UNICODE.
                streamUnicode.Write(arquivoSaida.ToString());

                //Fecha as streams
                ss.Close();

            }
            catch (InvalidCastException e)
            {

                //If occour a error, show a menssage
                System.Console.WriteLine("MSG: Error found when execute the conversion.");
                throw (e);

            }

        }

        private void convertWithRecursion(String directory, bool recursible, String filter)
        {
            try
            {

                //Set a directory to work
                DirectoryInfo dir = new DirectoryInfo(directory);

                //Declare Class to convert a files
                ansi2unicode convertDirectory = new ansi2unicode();

                //Declare variable to workFolder
                String workFolder = dir.FullName;

                //Confirm if last char of directory is "\"
                if (dir.FullName.Substring(dir.FullName.Length - 1, 1).Equals(@"\") == false)
                {
                    workFolder += @"\";
                }

                //Declare a list of subdirectories for directory dir
                DirectoryInfo[] subDir = dir.GetDirectories();

                //Case exists subdirectories
                if (subDir.Length > 0 & recursible == true)
                {

                    //Loop into subdirectories
                    foreach (DirectoryInfo dirInfo in subDir)
                    {

                        //Convert directory files from ANSI to UNICODE
                        convertDirectory.convertWithRecursion(dirInfo.FullName, true, filter);
                        //Console.WriteLine(dirInfo.FullName);

                    }

                }

                //Declare a list of files to work
                FileInfo[] files = dir.GetFiles(filter);

                //Convert files from directory
                foreach (FileInfo fInfo in files)
                {

                    //Convert file from ANSI to UNICODE
                    convertDirectory.convertFile2Unicode(workFolder + fInfo.Name, workFolder + fInfo.Name);
                    //Console.WriteLine(workFolder + fInfo.Name);

                }

            }
            catch (InvalidCastException e)
            {

                //If occour a error, show a menssage
                System.Console.WriteLine("MSG: Error found when execute the recursible.");
                throw (e);

            }

        }

        private void showHelp()
        {

            System.Console.WriteLine("");
            System.Console.WriteLine("ENGLISH");
            System.Console.WriteLine("ansi2unicode Help - Program to convert ANSI files to UNICODE files.");
            System.Console.WriteLine("");
            System.Console.WriteLine("    -i [File]      : Input Parameter");
            System.Console.WriteLine("    -o [File]      : Output Parameter");
            System.Console.WriteLine("    -d [Directory] : Directory from list files");
            System.Console.WriteLine("    -R             : List Recursible Files (Only for -d)");
            System.Console.WriteLine("    -f             : Filter for Files (Only for -d)");
            System.Console.WriteLine("    -h             : Show this help");
            System.Console.WriteLine("");
            System.Console.WriteLine("PORTUGUES");
            System.Console.WriteLine("Ajuda do ansi2unicode - Programa para converter arquivos ANSI para arquivos UNICODE.");
            System.Console.WriteLine("");
            System.Console.WriteLine("    -i [Arquivo]   : Parametro de Entrada");
            System.Console.WriteLine("    -o [Arquivo]   : Parametro de Saida");
            System.Console.WriteLine("    -d [Diretorio] : Diretorio dos arquivos");
            System.Console.WriteLine("    -R             : Lista arquivos recursivos (Somente para -d)");
            System.Console.WriteLine("    -f             : Filtro de arquivos (Somente para -d)");
            System.Console.WriteLine("    -h             : Mostra esta ajuda");
            System.Console.WriteLine("");
            System.Console.WriteLine("Developed by DirectTalk( www.directtalk.com.br ) ");
            System.Console.WriteLine("");

        }
    }
}
