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
        private TipoSangreEnum _tipo;
        public TipoSangre()
        {
            _tipo = TipoSangreEnum.NN;
        }
        public TipoSangreEnum SetTipo
        {
            set{_tipo = value;}
        }
        public string GetTipo{
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