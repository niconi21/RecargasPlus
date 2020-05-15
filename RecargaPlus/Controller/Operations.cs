using Controller.cache;
using Controller.objects;
using Controller.tools;
using Controller.WebReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Operations
    {
        Consultas _consulta;
        public List<Bonificacion> getBonificaciones()
        {
            _consulta = new Consultas();
            String respuesta = _consulta.getBonificaciones();
            List<Bonificacion> bonificaciones = new List<Bonificacion>();
            if (!respuesta.Equals(""))
            {
                var lineas = respuesta.Split('-');
                foreach (var linea in lineas)
                {
                    if (!linea.Equals(""))
                    {
                        var datos = linea.Split(',');
                        bonificaciones.Add(new Bonificacion
                        {
                            ID = int.Parse(datos[0]),
                            bonificacion = double.Parse(datos[1]),
                            Compania = new Compania
                            {
                                ID = int.Parse(datos[2]),
                                compania = datos[3]
                            },
                            Monto = new Monto
                            {
                                ID = int.Parse(datos[4]),
                                monto = double.Parse(datos[5])
                            }
                        });
                    }
                }
            }
            return bonificaciones;
        }
        public Bonificacion getBonificacion(int idCompania, int idMonto)
        {
            _consulta = new Consultas();
            String respuesta = _consulta.getBonificacion(idCompania, idMonto);
            Bonificacion bonificacion = new Bonificacion();
            if (!respuesta.Equals(""))
            {
                var datos = respuesta.Split(',');
                bonificacion = new Bonificacion
                {
                    ID = int.Parse(datos[0]),
                    bonificacion = double.Parse(datos[1])
                };
                   
            }
            return bonificacion;
        }
        public List<Colaborador> getColaboradores()
        {
            _consulta = new Consultas();
            String respuesta = _consulta.getColaboradores();
            List<Colaborador> colaboradores = new List<Colaborador>();
            if (!respuesta.Equals(""))
            {
                var lineas = respuesta.Split('-');
                foreach (var linea in lineas)
                {
                    if (!linea.Equals(""))
                    {
                        var datos = linea.Split(',');
                        colaboradores.Add(new Colaborador
                        {
                            IdPersona = int.Parse(datos[0]),
                            Nombre = datos[1],
                            Apepat = datos[2],
                            Apemat = datos[3],
                            Usuario = datos[4],
                            Clave = datos[5],
                            Tipo = byte.Parse(datos[6]) == 0 ? Strings.ADMINISTRADOR : Strings.COLABORADOR,
                            IdColaborador = int.Parse(datos[7]),
                            Saldo = double.Parse(datos[8])
                        });
                    }
                }
            }
            return colaboradores;
        }
        public List<Compania> getCompanias()
        {
            _consulta = new Consultas();
            String respuesta = _consulta.getCompanias();
            List<Compania> companias = new List<Compania>();
            if (!respuesta.Equals(""))
            {
                var lineas = respuesta.Split('-');
                foreach (var linea in lineas)
                {
                    if (!linea.Equals(""))
                    {
                        var datos = linea.Split(',');
                        companias.Add(new Compania
                        {
                            ID = int.Parse(datos[0]),
                            compania = datos[1]
                        });
                    }
                }
            }
            return companias;
        }
        public List<Monto> getMontos()
        {
            _consulta = new Consultas();
            String respuesta = _consulta.getMontos();
            List<Monto> montos = new List<Monto>();
            if (!respuesta.Equals(""))
            {
                var lineas = respuesta.Split('-');
                foreach (var linea in lineas)
                {
                    if (!linea.Equals(""))
                    {
                        var datos = linea.Split(',');
                        montos.Add(new Monto
                        {
                            ID = int.Parse(datos[0]),
                            monto = double.Parse(datos[1])
                        });
                    }
                }
            }
            return montos;
        }
        public List<Recarga> getRecargas(int idPersona)
        {
            _consulta = new Consultas();
            String respuesta = _consulta.getRecargas(idPersona);
            List<Recarga> recargas = new List<Recarga>();
            if (!respuesta.Equals(""))
            {
                var lineas = respuesta.Split('_');
                foreach (var linea in lineas)
                {
                    if (!linea.Equals(""))
                    {
                        var datos = linea.Split(',');
                        recargas.Add(new Recarga
                        {
                            ID = int.Parse(datos[0]),
                            Numero = datos[1],
                            Colaborador = new Colaborador
                            {
                                IdPersona = int.Parse(datos[2]),
                                Nombre = datos[3],
                                Apepat = datos[4],
                                Apemat = datos[5],
                            },
                            Bonificacion = new Bonificacion
                            {
                                ID = int.Parse(datos[6]),
                                bonificacion = double.Parse(datos[7])
                            },
                            Monto = new Monto
                            {
                                ID = int.Parse(datos[8]),
                                monto = double.Parse(datos[9])
                            },
                            Compania = new Compania
                            {
                                ID = int.Parse(datos[10]),
                                compania = datos[11]
                            }
                        });
                    }
                }
            }
            return recargas;
        }
        public bool login(String usuario, String clave)
        {
            _consulta = new Consultas();
            String respuesta = _consulta.login(usuario, clave);
            if (!respuesta.Equals(""))
            {
                var datos = respuesta.Split(',');
                Usuario_cache.IdPersona = int.Parse(datos[0]);
                Usuario_cache.Nombre = datos[1];
                Usuario_cache.Apepat = datos[2];
                Usuario_cache.Apemat = datos[3];
                Usuario_cache.Usuario = datos[4];
                Usuario_cache.Clave = datos[5];
                Usuario_cache.Tipo = byte.Parse(datos[6]) == 0 ? Strings.ADMINISTRADOR : Strings.COLABORADOR;
                if (Usuario_cache.Tipo.Equals(Strings.COLABORADOR))
                    Usuario_cache.Saldo = double.Parse(datos[7]);
                return true;
            }
            return false;
        }
        public bool setBonificacion(double bonificacion, int idMonto, int idCompania)
        {
            _consulta = new Consultas();
            bool respuesta = _consulta.setBonificacion(bonificacion, idMonto, idCompania);
            return respuesta;
        }
        public bool setColaborador(String nombre, String apepat, String apemat, String usuario, String clave, double saldo)
        {
            _consulta = new Consultas();
            bool respuesta = _consulta.setColaborador(nombre, apepat, apemat, usuario, clave, saldo);
            return respuesta;
        }
        public bool setCompania(String compania)
        {
            _consulta = new Consultas();
            bool respuesta = _consulta.setCompania(compania);
            return respuesta;
        }
        public bool setRecarga(String numero, int idPersona, int idBonificacion, int idMonto, int idCompania)
        {
            _consulta = new Consultas();
            var respuesta = _consulta.setRecarga(numero, idPersona, idBonificacion, idMonto, idCompania);
            return respuesta;
        }
        public bool setMonto(double monto)
        {
            _consulta = new Consultas();
            bool respuesta = _consulta.setMonto(monto);
            return respuesta;
        }
        public bool updateBonificacion(int idBonificacion, double bonificacion, int idMonto, int idCompania)
        {
            _consulta = new Consultas();
            var respuesta = _consulta.updateBonificacion(idBonificacion, bonificacion, idMonto, idCompania);
            return respuesta;
        }
        public bool updateColaborador(int idColaborador, String nombre, String apepat, String apemat, String usuario, String clave, double saldo)
        {
            _consulta = new Consultas();
            var respuesta = _consulta.updateColaborador(idColaborador, nombre, apepat, apemat, usuario, clave, saldo);
            return respuesta;
        }
    }
}
