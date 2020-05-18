package com.example.recargaplus.ui.Recargas.ui;

import androidx.lifecycle.ViewModelProviders;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.recargaplus.R;

import java.util.ArrayList;

import Objects.Bonificacion;
import Objects.Compania;
import Objects.Monto;
import Objects.Operations;
import Objects.Usuario_cache;

public class Recargad extends Fragment {

    private RecargadViewModel mViewModel;
    Spinner sCompanias;
    Spinner sMontos;
    Button btnRecarga;
    EditText edNumero;
    TextView tV_Saldo;
    public static Recargad newInstance() {
        return new Recargad();
    }

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {
        View vista = inflater.inflate(R.layout.recargad_fragment, container, false);
        tV_Saldo = vista.findViewById(R.id.tvSaldo);
        tV_Saldo.setText("Saldo: $" + Usuario_cache.saldo);
        final ArrayList<Monto> montos = (new Operations()).getMontos();
        ArrayList<String> cantidades = new ArrayList<String>();
        for (Monto monto : montos) {
            cantidades.add(monto.getMonto() + "");
        }
        ArrayAdapter<String> adapterMonto = new ArrayAdapter<String>(getContext(),
                android.R.layout.simple_spinner_item, cantidades);

        final ArrayList<Compania> companias = (new Operations()).getCompanias();
        ArrayList<String> nombresCompanias = new ArrayList<String>();
        for (Compania compania : companias) {
            nombresCompanias.add(compania.getCompania());
        }
        ArrayAdapter<String> adapterCompanias = new ArrayAdapter<String>(getContext(),
                android.R.layout.simple_spinner_item, nombresCompanias);

        sCompanias = vista.findViewById(R.id.spinner_companias);
        sCompanias.setAdapter(adapterCompanias);
        sMontos = vista.findViewById(R.id.spinner_montos);
        sMontos.setAdapter(adapterMonto);
        btnRecarga = vista.findViewById(R.id.btn_recarga);
        edNumero = vista.findViewById(R.id.ed_numero);
        btnRecarga.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                double saldo = Usuario_cache.saldo;
                double recarga = Double.parseDouble(sMontos.getSelectedItem().toString());
                if(saldo - recarga >= 0 ) {
                    String numero = edNumero.getText().toString();
                    int idMonto = montos.get(sMontos.getSelectedItemPosition()).getId();
                    int idCompania = companias.get(sCompanias.getSelectedItemPosition()).getId();
                    Bonificacion bonificacion = (new Operations()).getBonificacion(idCompania, idMonto);
                    if ((new Operations()).setRecarga(numero, Usuario_cache.idPersona, bonificacion.getId(), idMonto, idCompania)) {
                        Usuario_cache.saldo = saldo - recarga;
                        (new Operations()).updateColaborador(Usuario_cache.idPersona, Usuario_cache.nombre, Usuario_cache.apepat, Usuario_cache.apemat, Usuario_cache.usuario, Usuario_cache.clave, Usuario_cache.saldo);
                        Toast.makeText(getContext(), "La recarga ha sido realizada", Toast.LENGTH_SHORT).show();
                        tV_Saldo.setText("Saldo: $"+Usuario_cache.saldo);
                    }else
                        Toast.makeText(getContext(), "Error: La recarga pudo realizarse", Toast.LENGTH_SHORT).show();
                }else
                    Toast.makeText(getContext(), "Error: No cuentas con saldo suficiente para hacer la recarga", Toast.LENGTH_SHORT).show();
            }
        });

        return vista;
    }

    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);


    }

}
