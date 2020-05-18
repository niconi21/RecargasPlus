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

import Objects.Operations;
import Objects.Usuario_cache;

public class MainActivity extends AppCompatActivity {
    Button ingresar;
    EditText etUsuario, etClave;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Usuario_cache.nombre = "";
        Usuario_cache.apepat = "";
        Usuario_cache.apemat = "";
        Usuario_cache.clave = "";
        Usuario_cache.usuario = "";
        Usuario_cache.idPersona = -1;
        Usuario_cache.tipo = -1;
        Usuario_cache.saldo = 0.0f;
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ingresar = findViewById(R.id.btn_ingresar);
        etUsuario = findViewById(R.id.atUsuario);
        etClave = findViewById(R.id.etClave);
        ingresar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Operations login = new Operations();
                String respuesta = login.login(etUsuario.getText().toString(), etClave.getText().toString());
                if (respuesta.toString().equals("anyType{}")) {
                    Toast.makeText(getApplicationContext(), R.string.erron_login_incorrecto, Toast.LENGTH_LONG).show();
                } else {
                    String[] datos = respuesta.split(",");
                    Usuario_cache.idPersona = Integer.parseInt(datos[0]);
                    Usuario_cache.nombre = datos[1];
                    Usuario_cache.apepat = datos[2];
                    Usuario_cache.apemat = datos[3];
                    Usuario_cache.usuario = datos[4];
                    Usuario_cache.clave = datos[5];
                    Usuario_cache.tipo = Byte.parseByte(datos[6]) == 0 ? R.string.administrador : R.string.colaborador;
                    if (Usuario_cache.tipo == R.string.colaborador)
                        Usuario_cache.saldo = Double.parseDouble(datos[7]);
                    else
                        Usuario_cache.saldo = 0.0;
                    Intent i = new Intent(getApplicationContext(), InicioNav.class);
                    startActivity(i);
                }
            }
        });
    }
}
