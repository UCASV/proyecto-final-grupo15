# **DOCUMENTACIÓN** **OFICIAL**
***
##  Aspectos técnicos del programa

> ###  **Softwares instalados**

**Visual Studio Community 2019.** Versión del software: 16.10.2.

**MySQL Server.** Versión del software: 8.0.19.

**MySQL Workbench.** Versión del software: 8.0.19.

> ### **Patrones de diseño**

**View Model**

> ### **Paquetes externos**

**Itext7.** Versión del paquete: 7.1.15.

**ItextSharp.** Versión del paquete: 5.5.13.2.

**MySql.EntityFrameworkCore.** Versión del paquete: 5.0.3.1.

**Microsoft.EntityFrameworkCore.** Versión del paquete: 5.0.7.

**Microsoft.EntityFrameworkCore.Design.** Versión del paquete: 5.0.7.

## **Instalación**

Recursos necesarios: MySQL Server (Versión: 8.0.19), MySQL Workbench (Versión: 8.0.19).
También cabe indicar que al registrar la contraseña de su MySQL esta debe de ser "admin123", para que sea compatible con el instalador y debe tener la base de datos "Proyecto", cuyas instrucciones para crearse e insertar los datos correspondientes están en el script "Proyecto.sql"

A continuación, se presentarán una serie de pasos a seguir que le permitirá al usuario descargar e instalar el software de manera correcta en su dispositivo.

1-Descargar la carpeta Vaccination-Booth

![1](https://user-images.githubusercontent.com/62676424/124219502-b414d080-dab9-11eb-8b25-fc9eb8c95904.png)

1.1- Esta carpeta se descargará en un archivo comprimido.

![2](https://user-images.githubusercontent.com/62676424/124219634-d1499f00-dab9-11eb-97ca-d6ab49f6836e.png)

2-Una vez se descargue la carpeta, debemos descomprimirla, para ello, daremos clic derecho en el archivo comprimido y seleccionaremos "Extraer aquí".

![3](https://user-images.githubusercontent.com/62676424/124220072-8419fd00-daba-11eb-973a-e85995064149.png)

3-Al descomprimir el archivo, nos debe de aparecer esta carpeta, ingresaremos a ella.

![4](https://user-images.githubusercontent.com/62676424/124220373-04406280-dabb-11eb-93ae-cd8b31727f21.png)

4-Al ingresar a la carpeta, ingresaremos en la carpeta Debug.

![5](https://user-images.githubusercontent.com/62676424/124220465-1fab6d80-dabb-11eb-9c84-19b0f7879cb1.png)

5-Al ingresar a Debug, daremos doble click en Vaccination-Booth, para comenzar la instalación.

![6](https://user-images.githubusercontent.com/62676424/124220599-52edfc80-dabb-11eb-9228-64aa19427a91.png)

5.1-Una vez damos doble click, nos aparecerá un cuadro de diálogo que indica que la instalación ha comenzado.

![7](https://user-images.githubusercontent.com/62676424/124220795-ac562b80-dabb-11eb-8e4d-a4847ba6e2d1.png)

6-Nos aparecerá la ventana del Asistente para la instalación de Vaccination-Booth, daremos click en siguiente.

![8](https://user-images.githubusercontent.com/62676424/124220897-dc053380-dabb-11eb-8b6c-bbf248bd9ab5.png)

7-En la siguiente ventana "Seleccionar carpeta de instalación", nos aseguraremos que esté seleccionado "Solo para este usuario" y damos click en siguiente.

![9](https://user-images.githubusercontent.com/62676424/124221064-330b0880-dabc-11eb-8e9a-c736f8927cbf.png)

8-En la siguiente ventana "Confirmar instalación", damos click en siguiente.

![10](https://user-images.githubusercontent.com/62676424/124221167-6c437880-dabc-11eb-8ac5-33cda31bdbe3.png)

9-Nos aparecerá la ventana "Instalación completada", damos en click en cerrar.

![13](https://user-images.githubusercontent.com/62676424/124221215-8c733780-dabc-11eb-9667-ecc5fe981b0e.png)

10-Nos debe de aparecer el archivo ejecutable en el escritorio.

![14](https://user-images.githubusercontent.com/62676424/124221249-a01e9e00-dabc-11eb-93d0-91e1f4cdb4bc.png)

11-Finalmente, ingresamos al programa para asegurarnos que funcione correctamente.

![15](https://user-images.githubusercontent.com/62676424/124221291-b7f62200-dabc-11eb-892d-f9c82546a1aa.png)

## **Manual de Usuario**

> ### **Descripción general del software**

Este software gestiona el proceso de vacunación de una persona a través de un usuario que administra el programa (conocido como gestor), para ingresar al sistema, el gestor debe iniciar sesión colocando correctamente el nombre de usuario y contraseña que se han establecido para él, una vez ingresado al sistema, se le presenta al gestor, un menú con cuatro opciones disponibles, la primera empleados, la segunda registro, la tercera prechequeo y la cuarta monitoreo de citas. Si el usuario escoge empleados, podrá tener acceso al listado de empleados, si escoge registro, una vez complete los campos necesarios, podrá registrar al usuario, registrar la cita, y obtener los datos de la misma. Si el usuario escoge prechequeo tendrá la opción de buscar un usuario, completar o modificar sus datos de ser necesario, avanzarlo en la fila, registrar su proceso de vacunación y finalmente asignarle una segunda cita. Al finalizar cualquiera de los dos procesos, el gestor puede regresar al menú principal, en la que, podrá presionar el botón de cerrar sesión para salir de su sesión y finalizar el programa.

>### **Formularios**

A continuación se presentarán los 7 formularios junto con su descripción, funcionalidad e instrucciones de uso.

#### **Formulario: Inicio de Sesión**

![InicioSesion](https://user-images.githubusercontent.com/62676424/123669058-f1970680-d7f8-11eb-834e-bea6df45e98a.jpeg)

El programa comienza con "Inicio de Sesión", el cual, le permite al gestor colocar su nombre de usuario y contraseña para iniciar sesión en la plataforma y utilizarla. Es imperativo que el usuario coloque correctamente sus datos, caso contrario, no podrá ingresar a la plataforma.

#### **Formulario: Menú**

![menu](https://user-images.githubusercontent.com/62676424/124159469-6fa51880-da58-11eb-82ed-84eeda460311.png)

Una vez se inicia sesión correctamente se dirige hacia el menú principal, el menú principal tiene 4 botones los cuales permiten al usuario dirigirse a cuatro partes del programa, las cuales son: empleados (permite al gestor visualizar la lista de empleados y buscar los datos de uno), registro (permite al gestor registrar a un ciudadano), prechequeo (permite al gestor buscar a un ciudadano, modificar sus datos de ser necesario o crearlos y avanzarlo en la cola) Y monitoreo (permite ver si hay alguien en cola, registrar el momento en el que llega al monitoreo, avanzarlo a vacunación y posterior a ello, a observación donde se registra la cita para la segunda dosis).

#### **Formulario: Empleados**

![empl](https://user-images.githubusercontent.com/62676424/124160621-ad567100-da59-11eb-97ae-59eb1e57dd5c.png)

Al escoger la opción empleados en el menú, el gestor podrá visualizar un listado con todos los empleados. El gestor, podrá buscar un empleado en particular, ingresando su ID en el cuadro de texto y presionando el botón de buscar, una vez encontrado, se visualizarán únicamente los datos de dicho empleado.

#### **Formulario: Registro**

![RegistroCiudadanos](https://user-images.githubusercontent.com/62676424/123672393-7fc0bc00-d7fc-11eb-8d60-1049e76b2cc9.jpeg)

Al escoger la opción de registro en el menú, se ingresa hacia el formulario Registro, ahí se deberá completar correctamente los datos que se solicitan; de manera obligatoria se debe completar: número de DUI (sin guion y recordando que los números de DUI tienen nueve dígitos), nombre de la persona, dirección actual, número de teléfono (sin guion y recordando que los teléfonos tiene ocho dígitos) y la fecha de nacimiento de la persona; de manera opcional se debe completar el correo electrónico, si pertenece a una institución de prioridad deberá completar el número identificador y seleccionar a la institución a la que pertenece con la barra desplegable "Escoja la institución" (de pertenecer a una institución, es imperativo que ingrese el número identificador y seleccione la institución, si uno de los dos datos falta, no le permitirá avanzar), y finalmente seleccionar los recuadros correspondientes a las enfermedades crónicas que padece, de no padecer ninguna, simplemente no seleccionar ninguna opción

Abajo de los datos a solicitar hay dos botones, el primero , de izquierda a derecha, es generar PDF, el segundo es el botón Guardar. 

![boton pdf y guardar](https://user-images.githubusercontent.com/62676424/124163580-ecd28c80-da5c-11eb-8efc-b2b4e95da4ab.png)

El botón Guardar permite registrar al ciudadano en el sistema, al igual que registrar su cita, de haber llenado adecuadamente el formulario, aparecerá un cuadro de diálogo, anunciando el éxito de la operación. El botón generar PDF permite generar y guardar en la computadora un documento PDF, esto se podrá hacer únicamente si usted ha registrado al usuario con anticipación, de lo contrario, dará error.

#### **Formulario: Prechequeo**

![Precheck](https://user-images.githubusercontent.com/62676424/124181584-ecdd8700-da72-11eb-85cf-853c4c9d7c44.jpg)

El formulario contiene en la parte superior en la que debe ingresar el ID del ciudadano a buscar (este ID debe estar registrado y no es válido colocar caracteres que no le corresponden al ID), una vez se coloque el ID que corresponde al ciudadano y se presione buscar, aparecerán los datos del ciudadano.
Si el usuario colocó un dato equivocado en su registro, el gestor podrá corregírselo. Una vez, se verifiquen los datos, debe asegurarse que la persona de su consentimiento para recibir la dosis, caso contrario, no lo dejará avanzar.

![Precheck succesful](https://user-images.githubusercontent.com/62676424/124181843-4d6cc400-da73-11eb-9d3e-a01d47cb3294.png)

Una vez el ciudadano ha dado su consentimiento y se selecciona dicha casilla, aparecerá un cuadro de diálogo cuyo título será "operación exitosa", que indicara que el ciudadano ha sido ingresado a la cola. Para continuar con monitoreo de citas, deberá dar clic en volver, el cual le redirigirá al menú principal.

#### **Formulario: Monitoreo de citas**

![citasss](https://user-images.githubusercontent.com/62676424/124166581-438d9580-da60-11eb-9860-a7f610dd6819.png)

Al escoger la opción monitoreo en el menú principal, se encontrará con la ventana, monitoreo de citas, ahí, se tendrá acceso a la cola de pacientes esperando por avanzar en su proceso, para avanzar al ciudadano en la cola, el gestor podrá seleccionar el botón con la flecha que se encuentra a la izquierda del DUI del ciudadano que desea avanzar y podrá agregarlo a la lista.

#### **Formulario: Registro de vacunación**

![RegistroVacunacion](https://user-images.githubusercontent.com/62676424/124166726-733c9d80-da60-11eb-9c1b-08cd0391360a.jpg)

Una vez se avance al ciudadano en la cola, se dirigirá al registro de vacunación, al ser vacunado el ciudadano, se deberá presionar el botón "vacunado". Al presionar el botón, habrá un tiempo de espera, cuando este termine, la barra indicará al completarse de color verde y aparecerá un cuadro de diálogo mencionando que el tiempo de observación ha terminado.

#### **Formulario: Observación**

![Observation](https://user-images.githubusercontent.com/62676424/124181471-c28bc980-da72-11eb-8b78-3ea5d70800b1.png)


Como último paso, se avanzará al ciudadano a observación, donde tendrá que seleccionar al ciudadano y seleccionar cuál o cuáles son los efectos secundarios que presenta después que se le haya aplicado la vacuna.  En caso de no haber ninguno, no se seleccionará nada. Independientemente el ciudadano presente o no efectos secundarios, se deberá presionar el botón agregar efectos. El botón agrega los efectos secundarios y también permite agendar la segunda cita del ciudadano. 

Del gestor y el usuario necesitarlo, se podrá generar un PDF que indique los datos del ciudadano, los efectos secundarios que presentó y el detalle de su segunda cita.


> ### **Posibles errores**
A continuación se presentarán los posibles errores con los que se puede encontrar en el transcurso del programa, la causa del por qué ocurrirán y la solución a los mismos.


| Error      |                                                       Descripción                                                       | Imagen |
|------------|:--------------------------------------------------------------------------------------------------------------------:|:-----------:|
| Inicio de Sesión | Como se había mencionado al explicar cada formulario, es imperativo que el gestor coloque bien sus datos, caso contrario, aparecerá un cuadro de diálogo que indicará "Error" y no lo dejará avanzar hasta ingresar el nombre de usuario y contraseña correctos. | ![loginerror](https://user-images.githubusercontent.com/62676424/124168142-f90d1880-da61-11eb-8455-49fa3f403187.png)|
| Registro ciudadano: error 1 |Registro de ciudadanos requiere mucho cuidado al momento de llenar información. Al aparecer el cuadro de diálogo "Asegúrese de llenar la información correctamente", le indica al usuario que un campo está vacío o, en su defecto, que la persona ha agregado un número de identificador pero no ha seleccionado una institución o viceversa. Para solucionarlo, asegúrese de haber llenado los campos obligatorios, que el número de teléfono y número de DUI tengan 8 y 9 dígitos respectivamente y no tener discrepancias en los datos opcionales. También, este error se extiende a no ingresar un ID válido, datos alfabéticos o alfanuméricos como "hola" u "Hola123" no se pueden ingresar, tampoco se puede repetir el registro de un ciudadano previamente registrado, ya que el sistema detectará dos DUIs repetidos, por lo tanto, no dejará registrar por segunda vez al usuario.|![regerror](https://user-images.githubusercontent.com/62676424/124171000-3921ca80-da65-11eb-8e95-f105692dfc25.png)|
| Registro ciudadano: error 2 |El segundo error que encontramos en el formulario Ciudadano se indica al aparecer el cuadro de diálogo "No es posible registrar al ciudadano debido a que ya realizó un registro en el sitio web", como el mensaje lo indica, quiere decir que el ciudadano ya se ha registrado en el sitio web, por lo cual no se debbe volver a registrar y debe avanzar a Prechequeo.|![WhatsApp Image 2021-07-01 at 5 24 43 PM](https://user-images.githubusercontent.com/62676424/124200863-9e8cb000-da93-11eb-9e89-56faa1e677ac.jpeg)|
| Registro ciudadano: error 3 |El tercer y último error que se encuentra en el formulario Ciudadano se indica al aparecer el cuadro de diálogo "El/la ciudadano/a ya posee una cita para una dosis de la vacuna", advirtiendo que el ciudadano ya fue registrado anteriormente y ya se le reservó una cita, por lo que no se le debe volver a registrar y se debe dirigir a Prechequeo.|![WhatsApp Image 2021-07-01 at 5 27 36 PM](https://user-images.githubusercontent.com/62676424/124201011-1064f980-da94-11eb-97a4-9d98ed7efe7f.jpeg)|
| Prechequeo: error 1 |En el formulario prechequeo, al aparecer el cuadro de diálogo con "El/la ciudadano no posee registro de cita", indica que el DUI que ingresó no corresponde a ningún ciudadano registrado, para corregir esto debe verificar si ingresó correctamente el número de DUI del ciudadano o, regresar al formulario registro y regitsrar a la persona.|![preerror2](https://user-images.githubusercontent.com/62676424/124171395-bf3e1100-da65-11eb-8b50-9c085271b0df.png)|
| Prechequeo: error 2 |Otro error que puede ocurrir se indicará aparecer el cuadro de diálogo con "Algo salió mal con la búsqueda", indica que no ha ingresado ningún DUI para buscar o ha ingresado datos inválidos (caracteres alfabéticos o alfanuméricos).|![preerror1](https://user-images.githubusercontent.com/62676424/124172041-936f5b00-da66-11eb-881c-1cb36b030237.png)|
| Prechequeo: error 3 |Este error se indicará a través del cuadro de diálogo "El/la ciudadano/a no posee cita para el día de hoy". Este error se debe a que se ha ingresado a una persona que ya recibió su primera dosis o ya avanzó el proceso de Prechequeo.|![ERROR2](https://user-images.githubusercontent.com/62676424/124191589-38972d00-da81-11eb-83c4-3774a919b9d5.png)|
| Prechequeo: error 4 |El último error que puede aparecer en Prechequeo se indicará a través del cuadro de diálogo "Debe aceptar que desea recibir la vacuna". El consentimiento de la persona para recibir la vacuna es sumamente importante, para ello se debe marcar la casilla que está a la derecha de "¿Acepta recibir la dosis de la vacuna?", mientras no esté seleccionado, no le permitirá avanzar.|![ERROR2](https://user-images.githubusercontent.com/62676424/124191903-b65b3880-da81-11eb-946d-2f73941aec95.png)|
| Monitoreo de citas |El error que puede aparecer en Monitoreo de citas se indicará a través del cuadro de diálogo "Se encuentra un paciente el cola". Este error se soluciona seleccionando el botón de la flecha (el cual está la izquierda del DUI del ciudadano), una vez seleccionado se avanzará al ciudadano al siguiente formulario.|![ERROR1](https://user-images.githubusercontent.com/62676424/124192115-00441e80-da82-11eb-949b-e9d5d467eaa9.png)|
