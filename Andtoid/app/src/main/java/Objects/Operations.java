package Objects;

import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.widget.Toast;

import com.example.recargaplus.InicioNav;
import com.example.recargaplus.R;
import com.google.android.material.appbar.AppBarLayout;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ExecutionException;
import java.util.zip.DeflaterOutputStream;

public class Operations extends AsyncTask<Object, Void, String> {

    public final String NAMESPACE = "http://tempuri.org/";
    public final String DIRECCION = "http://192.168.1.72/webServicesRecargaPlus/Consultas.asmx";
    public String metodo = "";
    public String soap_action = "http://tempuri.org/";


    private SoapObject solicitud;
    private HttpTransportSE transporte;
    private SoapSerializationEnvelope serializar;
    private Object respuesta;

    ArrayList<PropertyInfo> propiedades;


    @Override
    protected String doInBackground(Object... objects) {
        this.solicitud = new SoapObject(this.NAMESPACE, this.metodo);
        for (PropertyInfo propiedad: this.propiedades) {
            solicitud.addProperty(propiedad);
        }
        this.serializar = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        this.serializar.dotNet = true;
        this.serializar.setOutputSoapObject(this.solicitud);
        this.transporte = new HttpTransportSE(this.DIRECCION);
        try {
            this.transporte.call(this.soap_action, serializar);
            this.respuesta = serializar.getResponse();
        } catch (Exception ex) {
            System.err.println("Error");
            this.respuesta = ex.toString();
        }
        return respuesta.toString();
    }

    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);
        this.respuesta = s;
    }

    public String login(String usuario,String clave){
        try {
            this.metodo = "login";
            this.soap_action += this.metodo;
            PropertyInfo pUsuario = new PropertyInfo();
            pUsuario.setName("usuario");
            pUsuario.setValue(usuario);
            pUsuario.setType(String.class);
            PropertyInfo pClave = new PropertyInfo();
            pClave.setName("clave");
            pClave.setValue(clave);
            pClave.setType(String.class);
            this.propiedades = new ArrayList<PropertyInfo>();
            this.propiedades.add(pUsuario);
            this.propiedades.add(pClave);
            this.respuesta = this.execute(usuario, clave).get();

        }catch (Exception e){
            System.out.println("Login");
            System.out.println(e.toString());
        }
        return  this.respuesta.toString();
    }

    public ArrayList<Monto> getMontos(){
        this.metodo = "getMontos";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        ArrayList<Monto> montos = new ArrayList<Monto>();
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}"))
            {
                String[] lineas = respuesta.toString().split("-");
                for(String linea : lineas)
                {
                    if (!linea.equals(""))
                    {
                        String[] datos = linea.split(",");
                        Monto monto = new Monto();
                        monto.setId(Integer.parseInt(datos[0]));
                        monto.setMonto(Double.parseDouble(datos[1]));
                        montos.add(monto);
                    }
                }
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return montos;

    }

    public ArrayList<Compania> getCompanias(){
        this.metodo = "getCompanias";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        ArrayList<Compania> companias = new ArrayList<Compania>();
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}"))
            {
                String[] lineas = respuesta.toString().split("-");
                for(String linea : lineas)
                {
                    if (!linea.equals(""))
                    {
                        String[] datos = linea.split(",");
                        Compania compania= new Compania();
                        compania.setId(Integer.parseInt(datos[0]));
                        compania.setCompania(datos[1]);
                        companias.add(compania);
                    }
                }
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return companias;

    }

    public ArrayList<Bonificacion> getBonificaciones(){
        this.metodo = "getBonificaciones";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        ArrayList<Bonificacion> bonificaciones = new ArrayList<Bonificacion>();
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                String[] lineas = respuesta.toString().split("-");
                for (String linea : lineas) {
                    if (!linea.equals("")) {
                        String[] datos = linea.split(",");
                        Bonificacion bonificacion = new Bonificacion();
                        bonificacion.setId(Integer.parseInt(datos[0]));
                        bonificacion.setBonificacion(Double.parseDouble(datos[1]));
                        bonificacion.compania.setId(Integer.parseInt(datos[2]));
                        bonificacion.compania.setCompania(datos[3]);
                        bonificacion.monto.setId(Integer.parseInt(datos[4]));
                        bonificacion.monto.setMonto(Double.parseDouble(datos[5]));
                        bonificaciones.add((bonificacion));
                    }
                }
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return bonificaciones;

    }

    public Bonificacion getBonificacion(int idCompania, int idMonto){
        this.metodo = "getBonificacion";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        PropertyInfo pIdCompania = new PropertyInfo();
        pIdCompania.setName("idCompania ");
        pIdCompania.setValue(idCompania);
        pIdCompania.setType(Integer.class);
        PropertyInfo pIdMonto = new PropertyInfo();
        pIdMonto.setName("idMonto");
        pIdMonto.setValue(idMonto);
        pIdMonto.setType(Integer.class);
        propiedades.add(pIdCompania);
        propiedades.add(pIdMonto);
        Bonificacion bonificacion = new Bonificacion();
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                String[] datos = respuesta.toString().split(",");
                bonificacion.setId(Integer.parseInt(datos[0]));
                bonificacion.setBonificacion(Double.parseDouble(datos[1]));
            }
        } catch (ExecutionException e) {
            System.out.println(e.toString());
        } catch (InterruptedException e) {
            System.out.println(e.toString());
        }

        return bonificacion;

    }

    public ArrayList<Colaborador> getColaboradores(){
        this.metodo = "getColaboradores";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        ArrayList<Colaborador> colaboradores = new ArrayList<Colaborador>();
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                String[] lineas = respuesta.toString().split("-");
                for(String linea : lineas)
                {
                    if (!linea.equals("")) {
                        String[] datos = linea.split(",");
                        Colaborador colaborador = new Colaborador();

                        colaborador.setIdPersona(Integer.parseInt(datos[0]));
                        colaborador.setNombre(datos[1]);
                        colaborador.setApepat(datos[2]);
                        colaborador.setApemat(datos[3]);
                        colaborador.setUsuario(datos[4]);
                        colaborador.setClave(datos[5]);
                        colaborador.setTipo(Byte.parseByte(datos[6]) == 0 ? R.string.administrador : R.string.colaborador);
                        colaborador.setIdColaborador(Integer.parseInt(datos[7]));
                        colaborador.setSaldo(Double.parseDouble(datos[8]));
                        colaboradores.add(colaborador);
                    }
                }
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return colaboradores;

    }

    public ArrayList<Recarga> getRecargas(int idPersona){
        this.metodo = "getRecargas";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        PropertyInfo pidPersona = new PropertyInfo();
        pidPersona.setName("idPersona");
        pidPersona.setValue(idPersona);
        pidPersona.setType(Integer.class);
        propiedades.add(pidPersona);
        ArrayList<Recarga> recargas = new ArrayList<Recarga>();
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                String[] lineas = respuesta.toString().split(",");
                for(String linea : lineas)
                {
                    if (!linea.equals("")) {
                        String[] datos = linea.split(",");
                        Recarga recarga = new Recarga();
                        recarga.setId(Integer.parseInt(datos[0]));
                        recarga.setNumero(datos[1]);
                        recarga.colaborador.setIdPersona(Integer.parseInt(datos[2]));
                        recarga.colaborador.setNombre(datos[3]);
                        recarga.colaborador.setApepat(datos[4]);
                        recarga.colaborador.setApemat(datos[5]);
                        recarga.bonificacion.setId(Integer.parseInt(datos[6]));
                        recarga.bonificacion.setBonificacion(Double.parseDouble(datos[7]));
                        recarga.monto.setId(Integer.parseInt(datos[8]));
                        recarga.monto.setMonto(Double.parseDouble(datos[9]));
                        recarga.compania.setId(Integer.parseInt(datos[10]));
                        recarga.compania.setCompania(datos[11]);
                    }
                }
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return recargas;

    }

    public boolean setBonificacion(double bonificacion, int idMonto, int idCompania){
        this.metodo = "setBonificacion";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        PropertyInfo pbonificacion = new PropertyInfo();
        pbonificacion.setName("bonificacion");
        pbonificacion.setValue(bonificacion);
        pbonificacion.setType(Double.class);
        PropertyInfo pidMonto = new PropertyInfo();
        pidMonto.setName("idMonto");
        pidMonto.setValue(idMonto);
        pidMonto.setType(Integer.class);
        PropertyInfo pidCompania = new PropertyInfo();
        pidCompania.setName("idCompania");
        pidCompania.setValue(idCompania);
        pidCompania.setType(Integer.class);
        propiedades.add(pbonificacion);
        propiedades.add(pidMonto);
        propiedades.add(pidCompania);
        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }

    public boolean setColaborador(String nombre, String apepat, String apemat, String usuario, String clave, double saldo){
        this.metodo = "setColaborador";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();

        PropertyInfo pNombre = new PropertyInfo();
        pNombre.setName("nombre");
        pNombre.setValue(nombre);
        pNombre.setType(String.class);

        PropertyInfo pApepat = new PropertyInfo();
        pApepat.setName("apepat");
        pApepat.setValue(apepat);
        pApepat.setType(String.class);

        PropertyInfo pApemat = new PropertyInfo();
        pApemat.setName("apemat");
        pApemat.setValue(apemat);
        pApemat.setType(String.class);

        PropertyInfo pusuario = new PropertyInfo();
        pusuario.setName("usuario");
        pusuario.setValue(usuario);
        pusuario.setType(String.class);

        PropertyInfo pclave = new PropertyInfo();
        pclave.setName("pclave");
        pclave.setValue(pclave);
        pclave.setType(String.class);

        PropertyInfo psaldo = new PropertyInfo();
        psaldo.setName("saldo");
        psaldo.setValue(saldo);
        psaldo.setType(Double.class);

        propiedades.add(pNombre);
        propiedades.add(pApepat);
        propiedades.add(pApemat);
        propiedades.add(pusuario);
        propiedades.add(pclave);
        propiedades.add(psaldo);
        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }

    public boolean setCompania(String compania){
        this.metodo = "setCompania";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();

        PropertyInfo pCompania = new PropertyInfo();
        pCompania.setName("compania");
        pCompania.setValue(compania);
        pCompania.setType(String.class);

        propiedades.add(pCompania);
        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }

    public boolean setRecarga(String numero, int idPersona, int idBonificacion, int idMonto, int idCompania){
        this.metodo = "setRecarga";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();

        PropertyInfo pnumero = new PropertyInfo();
        pnumero.setName("numero");
        pnumero.setValue(numero);
        pnumero.setType(String.class);

        PropertyInfo pidPersona = new PropertyInfo();
        pidPersona.setName("idPersona");
        pidPersona.setValue(idPersona);
        pidPersona.setType(Integer.class);

        PropertyInfo pidBonificacion = new PropertyInfo();
        pidBonificacion.setName("idBonificacion");
        pidBonificacion.setValue(idBonificacion);
        pidBonificacion.setType(Integer.class);

        PropertyInfo pidMonto = new PropertyInfo();
        pidMonto.setName("idMonto");
        pidMonto.setValue(idMonto);
        pidMonto.setType(Integer.class);

        PropertyInfo pidCompania = new PropertyInfo();
        pidCompania.setName("idCompania");
        pidCompania.setValue(idCompania);
        pidCompania.setType(Integer.class);

        propiedades.add(pnumero);
        propiedades.add(pidBonificacion);
        propiedades.add(pidMonto);
        propiedades.add(pidPersona);
        propiedades.add(pidCompania);
        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }

    public boolean setMonto(double monto){
        this.metodo = "setMonto";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();

        PropertyInfo pmonto = new PropertyInfo();
        pmonto.setName("monto");
        pmonto.setValue(monto);
        pmonto.setType(String.class);

        propiedades.add(pmonto);
        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }

    public boolean updateBonificacion(int idBonificacion, double bonificacion, int idMonto, int idCompania){
        this.metodo = "updateBonificacion";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();
        PropertyInfo pidBonificacion = new PropertyInfo();
        pidBonificacion.setName("idBonificacion ");
        pidBonificacion.setValue(idBonificacion );
        pidBonificacion.setType(Integer.class);

        PropertyInfo pbonificacion = new PropertyInfo();
        pbonificacion.setName("bonificacion");
        pbonificacion.setValue(bonificacion);
        pbonificacion.setType(Double.class);

        PropertyInfo pidMonto = new PropertyInfo();
        pidMonto.setName("idMonto");
        pidMonto.setValue(idMonto);
        pidMonto.setType(Integer.class);

        PropertyInfo pidCompania = new PropertyInfo();
        pidCompania.setName("idCompania");
        pidCompania.setValue(idCompania);
        pidCompania.setType(Integer.class);

        propiedades.add(pidBonificacion);
        propiedades.add(pbonificacion);
        propiedades.add(pidMonto);
        propiedades.add(pidCompania);
        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }

    public boolean updateColaborador(int idColaborador, String nombre, String apepat, String apemat, String usuario, String clave, double saldo){
        this.metodo = "updateColaborador";
        this.soap_action += this.metodo;
        this.propiedades = new ArrayList<PropertyInfo>();

        PropertyInfo pidColaborador = new PropertyInfo();
        pidColaborador.setName("idPersona");
        pidColaborador.setValue(idColaborador );
        pidColaborador.setType(Integer.class);

        PropertyInfo pnombre = new PropertyInfo();
        pnombre.setName("nombre");
        pnombre.setValue(nombre);
        pnombre.setType(String.class);

        PropertyInfo papepat = new PropertyInfo();
        papepat.setName("apepat");
        papepat.setValue(apepat);
        papepat.setType(String.class);

        PropertyInfo papemat = new PropertyInfo();
        papemat.setName("apemat");
        papemat.setValue(apemat);
        papemat.setType(String.class);

        PropertyInfo pusuario = new PropertyInfo();
        pusuario.setName("usuario");
        pusuario.setValue(usuario);
        pusuario.setType(String.class);

        PropertyInfo pclave = new PropertyInfo();
        pclave.setName("clave");
        pclave.setValue(clave);
        pclave.setType(String.class);

        PropertyInfo psaldo = new PropertyInfo();
        psaldo.setName("saldo");
        psaldo.setValue(saldo + "");
        psaldo.setType(String.class);

        propiedades.add(pidColaborador);
        propiedades.add(pnombre);
        propiedades.add(papepat);
        propiedades.add(papemat);
        propiedades.add(pusuario);
        propiedades.add(pclave);
        propiedades.add(psaldo);

        boolean res = false;
        try {
            this.respuesta = this.execute().get();
            if (!respuesta.equals("anyType{}")) {
                res = Boolean.parseBoolean(respuesta.toString());
                System.out.println( res ? "Se ha actualizado" : "No se ha actualizado");
                System.out.println("////////////" + respuesta);
            }
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return res;
    }
}
