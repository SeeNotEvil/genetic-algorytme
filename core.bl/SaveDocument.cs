using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using core.bl;
using Microsoft.Office.Core;

namespace core.bl
{


    

    public class SaveDocumentWord : ISaveDocument
    {
        private Microsoft.Office.Interop.Word.Application _oWord ;
        private Microsoft.Office.Interop.Word._Document _template;

        private string MARK_FUNCTION = "function";
        private string MARK_FUNCTION_RESTRICT = "restrics";
        private string MARK_VECTOR_RESULT = "vector_result" ;
        private string MARK_REAL_RESULT = "real_result";
        private string MARK_REAL_RESTRICT = "real_restrict";


        
        private string MARK_COUNT_GENERATION = "countGeneration";
        private string MARK_CHANCE_MUTATION = "сhanceMutation";
        private string MARK_COUNT_POPULATE = "countPopulate";
        private string MARK_VALUE_MUTATION = "valueMutation";
        private string MARK_TURN_INTEGER = "turnInteger";
        private string MARK_TIME = "time";

        private char CHAR_SPACE = ' ';
        private char CHAR_PLUS = '+';
        private char CHAR_COMMA = ',';

        private string SIGN_SPACE = " ";
        private string SIGN_PLUS = "+";
        private string SIGN_MINUS = "-";
        private string X = "x";
        private string SIGN_COMMA = ",";
        private string SIGN_EQUALLY = "=";
       
        private string _directoryTemplate = "\\template.dotx";

        public bool saveFile(String path, ContainerResult result, ContainerFunction containerFunction, Parametrs option)
        {
            createDocument(containerFunction, result, option);
      
            _template.SaveAs(FileName: path);
            _template.Close();
            _template = null;

            return true;
        }


        public SaveDocumentWord()
        {
            _oWord = new Microsoft.Office.Interop.Word.Application();
            
        }



        private void createDocument(ContainerFunction function, ContainerResult result, Parametrs option )
        {
         
            _template = _oWord.Documents.Add(Environment.CurrentDirectory + _directoryTemplate);
            Char[] chr = { CHAR_SPACE, CHAR_PLUS, CHAR_COMMA };
            String stroke = "";


            _template.Bookmarks[MARK_COUNT_GENERATION].Range.Text = option.countGeneration.ToString();
            _template.Bookmarks[MARK_CHANCE_MUTATION].Range.Text = option.сhanceMutation.ToString();
            _template.Bookmarks[MARK_COUNT_POPULATE].Range.Text = option.countPopulate.ToString();
            _template.Bookmarks[MARK_VALUE_MUTATION].Range.Text = option.valueMutation.ToString();
            _template.Bookmarks[MARK_TURN_INTEGER].Range.Text = option.turnInteger;
            _template.Bookmarks[MARK_TIME].Range.Text = result.time.ToString();

            if (result != null)
            {
               

                String vectorResult = "";
                String realResult = "";
                String realRestrict = "";
 
                int i = 1;
                foreach (int vect in result.vector)
                {
                    vectorResult += X + i.ToString() + SIGN_EQUALLY + vect + SIGN_COMMA + SIGN_SPACE + SIGN_SPACE;
                    i++;
                }

                stroke = vectorResult.Trim().Trim(chr);

                _template.Bookmarks[MARK_VECTOR_RESULT].Range.Text = stroke;

                realResult = result.realResult.ToString();

                _template.Bookmarks[MARK_REAL_RESULT].Range.Text = realResult;

                
                foreach (int vect in result.realRestrict)
                {
                    realRestrict += vect.ToString() + SIGN_COMMA + SIGN_SPACE + SIGN_SPACE + SIGN_SPACE;
                  
                }

                stroke = realRestrict.Trim().Trim(chr) + SIGN_SPACE;


                _template.Bookmarks[MARK_REAL_RESTRICT].Range.Text = stroke;

            }

            if (function != null)
            {
                String line = "";
                foreach (MatrixItem matrix in function.matrix)
                {
                    line = "" ;
                    int i = 1;
                    foreach (Double vect in matrix.items)
                    {


                        double num;

                        if (vect < 0)
                        {
                            line += SIGN_MINUS + SIGN_SPACE;
                            num = Math.Abs(vect);
                        }
                        else
                        {
                            num = vect;
                            line += SIGN_PLUS + SIGN_SPACE;
                        }

                        line += num.ToString() + X + i + SIGN_SPACE;

                        i++;
                    }


                    stroke = line.Trim().Trim(chr);
                    stroke += matrix.Sign;
                    stroke += SIGN_SPACE;

                    stroke += matrix.restriction.ToString();
                    _template.Bookmarks[MARK_FUNCTION_RESTRICT].Range.Text = stroke + Environment.NewLine;
                }

                

                String lineFunc = "";

                foreach (Double vect in function.fitness)
                {


                    double num;

                    if (vect < 0)
                    {
                        lineFunc += SIGN_MINUS + SIGN_SPACE;
                        num = Math.Abs(vect);
                    }
                    else
                    {
                        num = vect;
                        lineFunc += SIGN_PLUS + SIGN_SPACE;
                    }

                    lineFunc += num.ToString() + SIGN_SPACE;

          
                }

                stroke = lineFunc.Trim().Trim(chr) + function.cursor + SIGN_SPACE;
                _template.Bookmarks[MARK_FUNCTION].Range.Text = stroke;

            }

        }
    }
}
