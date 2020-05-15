# Recargas Plus

Agradecimiento por los iconos usados:
<link>https://www.flaticon.es/autores/freepik</link>

Hasta este momento este proyecto está terminado para la aplicación desktop, pero cabe mencionar que tiene ciertas excepciones no controladas en el momentos de llenar los datos en los formularios, esos poblemas se arreglarán al final por cuestiones de tiempo, si ves que tiene otros problemas hazmelo saber para que esté al pendiente y los corrija en el momento.

Para que puedas hacer usa de esta app tienes que hacer varias cosas, las cual te las enlistaré.

*Primera:  
    Tienes que ejecutar el script de la base de datos en sqlServer, debido a que este fue el motor de base de datos que usamos,
    solamente tienes que copiar este script 
    [RecargasPlus - Base de datos.sql](https://github.com/niconi21/RecargasPlus/blob/master/RecargasPlus%20-%20Base%20de%20datos.sql)
    
*Segundo  
    Encontrarás dos soluciones de visual studio.  
    [RecargaPlus](https://github.com/niconi21/RecargasPlus/tree/master/RecargaPlus)  
            Esta solución contiene la aplicación desktop, como podrás apreciar son dos proyectos, uno donde está la vista y otro proyeto llamado "Controller" donde hace la comunicación con el web service y transforma la información recibida/enviada en objetos para su uso.  
    [WebServicesRecargaPlus](https://github.com/niconi21/RecargasPlus/tree/master/WebServicesRecargaPlus)  
            En esta solución está el código del web services, lo unico que tienes que hacer el publicar esta servicio y copiar el link, para después reemplazarlo en la primera solución [RecargaPlus](https://github.com/niconi21/RecargasPlus/tree/master/RecargaPlus) en el apartado de WebReference, cambiando la URL.
            
De esta manera podrá usar la aplicación desktop, vienen usarios por defeto, los cuales son:  
<pre>
  Administrador: 
    Nombre - Nicolas Moreno Durán
    Usuario - niconi 
    clave - niconi    
</pre>
<pre>
  Colaborador: 
    Nombre - Francisco Enrique Alberto Cordova
    Usuario - francisco 
    clave - francisco
    
    Nombre - Josue Jared Camacho Rolon
    Usuario - josue 
    clave - josue
</pre>
