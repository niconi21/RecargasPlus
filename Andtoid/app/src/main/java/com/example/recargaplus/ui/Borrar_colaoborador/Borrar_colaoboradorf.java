package com.example.recargaplus.ui.Borrar_colaoborador;

import androidx.lifecycle.ViewModelProviders;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.recargaplus.R;

import java.util.ArrayList;

import Objects.Colaborador;
import Objects.Operations;

public class Borrar_colaoboradorf extends Fragment {

    private BorrarColaoboradorfViewModel mViewModel;

    public static Borrar_colaoboradorf newInstance() {
        return new Borrar_colaoboradorf();
    }
    Spinner sColaboradores;
    Button bBorrar;
    TextView tvNombre;
    TextView tvSaldo;
    public ArrayList<Colaborador> colaboradores;
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.borrar_colaoboradorf_fragment, container, false);
        sColaboradores = view.findViewById(R.id.spinnerColaboradores);
        tvNombre = view.findViewById(R.id.textViewNombre);
        tvSaldo = view.findViewById(R.id.textViewSaldo);
        bBorrar = view.findViewById(R.id.btn_borrar);
        colaboradores = (new Operations()).getColaboradores();
        ArrayList<String> nombres = new ArrayList<String>();
        for ( Colaborador colaborador : colaboradores){
            nombres.add(colaborador.getNombre() + " " + colaborador.getApepat() + " " + colaborador.getApemat());
        }
        ArrayAdapter<String> adapterNombres = new ArrayAdapter<String>(getContext(),
                android.R.layout.simple_spinner_item, nombres);
        sColaboradores.setAdapter(adapterNombres);

        sColaboradores.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                tvNombre.setText("Nombre: " + sColaboradores.getSelectedItem().toString());
                tvSaldo.setText("Saldo : $" + colaboradores.get(sColaboradores.getSelectedItemPosition()).getSaldo());

            }
            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }

        });
                /*
                 */

        bBorrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Colaborador colaborador = colaboradores.get(sColaboradores.getSelectedItemPosition());
                if((new Operations()).deleteColaborador(colaborador.getIdPersona())){
                    Toast.makeText(getContext(), "El colaborador ha sido borrado", Toast.LENGTH_LONG).show();
                }else{
                    Toast.makeText(getContext(), "Error: el colaborador no ha sido borrado", Toast.LENGTH_LONG).show();
                }

            }
        });


        return  view;
    }

    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);
        mViewModel = ViewModelProviders.of(this).get(BorrarColaoboradorfViewModel.class);
        // TODO: Use the ViewModel
    }

}
