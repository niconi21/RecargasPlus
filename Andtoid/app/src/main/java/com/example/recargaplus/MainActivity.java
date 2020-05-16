package com.example.recargaplus;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import Objects.Usuario_cache;

public class MainActivity extends AppCompatActivity {
    Button ingresar;
    EditText etUsuario, etClave;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ingresar = findViewById(R.id.btn_ingresar);
        etUsuario = findViewById(R.id.atUsuario);
        etClave = findViewById(R.id.etClave);
        ingresar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                LoginOperation login = new LoginOperation();
                login.execute(etUsuario.getText().toString(), etClave.getText().toString());
            }
        });
    }
    class LoginOperation extends AsyncTask<Object, Void, String> {

        public final String NAMESPACE = "http://tempuri.org/";
        public final String DIRECCION = "http://192.168.1.72/webServicesRecargaPlus/Consultas.asmx";
        public final String soap_action = "http://tempuri.org/login";
        public final String metodo = "login";
        private SoapObject solicitud;
        private HttpTransportSE transporte;
        private SoapSerializationEnvelope serializar;
        private Object respuesta;
        @Override
        protected String doInBackground(Object... objects) {
            this.solicitud = new SoapObject(this.NAMESPACE, this.metodo);
            PropertyInfo pUsuario = new PropertyInfo();
            pUsuario.setName("usuario");
            pUsuario.setValue(objects[0].toString());
            pUsuario.setType(String.class);
            this.solicitud.addProperty(pUsuario);

            PropertyInfo pClave = new PropertyInfo();
            pClave.setName("clave");
            pClave.setValue(objects[1].toString());
            pClave.setType(String.class);
            this.solicitud.addProperty(pClave);

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

            if(s.toString().equals("anyType{}")){
                Toast.makeText(getApplicationContext(), R.string.erron_login_incorrecto,Toast.LENGTH_LONG).show();
            }else {
                String[] datos = s.split(",");
                Usuario_cache.idPersona = Integer.parseInt(datos[0]);
                Usuario_cache.nombre = datos[1];
                Usuario_cache.apepat = datos[2];
                Usuario_cache.apemat = datos[3];
                Usuario_cache.usuario = datos[4];
                Usuario_cache.clave = datos[5];
                Usuario_cache.tipo = Byte.parseByte(datos[6]) == 0 ? R.string.administrador : R.string.colaborador;
                if (Usuario_cache.tipo == R.string.colaborador)
                    Usuario_cache.saldo = Double.parseDouble(datos[7]);
                Toast.makeText(getApplicationContext(), s,Toast.LENGTH_LONG).show();
            }
        }
    }
}
