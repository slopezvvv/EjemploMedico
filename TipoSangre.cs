using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploMedico
{
    public enum TipoSangreEnum
    {
        NN=0,ON=-1,OP=1,AN=-2,AP=2,BN=-3,BP=3,ABN=-4,ABP=4
    }
    public class TipoSangre
    {
        private static TipoSangreEnum _tipo = TipoSangreEnum.NN;
        public static short Parse(in int valor)
        {
            switch (valor)
            {
                case 1:
                    return (short)TipoSangreEnum.ON;
                case 2:
                    return (short)TipoSangreEnum.OP;
                case 3:
                    return (short)TipoSangreEnum.AN;
                case 4:
                    return (short)TipoSangreEnum.AP;
                case 5:
                    return (short)TipoSangreEnum.BN;
                case 6:
                    return (short)TipoSangreEnum.BP;
                case 7:
                    return (short)TipoSangreEnum.ABN;
                case 8:
                    return (short)TipoSangreEnum.ABP;
                default:
                    return (short)TipoSangreEnum.NN;
            }
        }
        public static List<string> ToList
        {
            get
            {
                return new List<string>() {
                    _tipo.ToString(),
                    TipoSangreEnum.ON.ToString(),
                    TipoSangreEnum.OP.ToString(),
                    TipoSangreEnum.AN.ToString(),
                    TipoSangreEnum.AP.ToString(),
                    TipoSangreEnum.BN.ToString(),
                    TipoSangreEnum.BP.ToString(),
                    TipoSangreEnum.ABN.ToString(),
                    TipoSangreEnum.ABP.ToString()
                };
            }
        }
        public static TipoSangreEnum SetTipo
        {
            set{_tipo = value;}
        }
        public static string GetTipo{
            get
            {
                switch (_tipo)
                {
                    case TipoSangreEnum.ON:
                        return "O-";
                    case TipoSangreEnum.OP:
                        return "O+";
                    case TipoSangreEnum.AN:
                        return "A+";
                    case TipoSangreEnum.AP:
                        return "A+";
                    case TipoSangreEnum.BN:
                        return "B-";
                    case TipoSangreEnum.BP:
                        return "B+";
                    case TipoSangreEnum.ABN:
                        return "AB-";
                    case TipoSangreEnum.ABP:
                        return "AB+";
                    default:
                        return _tipo.ToString();
                }
            }
        }
    }
}