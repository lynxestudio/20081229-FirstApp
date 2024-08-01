# Entendiendo los ensamblados (assemblies)

<p align="justify">
Una de las características más atractivas que ofrece la programación con .NET es la posibilidad de poder construir aplicaciones con diferentes lenguajes, cada compilador para .NET genera un módulo ejecutable conocido como <b>assembly</b> (ensamblado) que contiene instrucciones en un lenguaje llamado CIL (Common Intermediate Language) que es ejecutado por el CLR (Common Language Runtime).
A diferencia de un compilador para lenguajes como C, Fortran o Pascal que produce codigo binario especifico para cada procesador, como el que se ve en la siguiente imagen:
</p>
<img src="compilation.png"/>
<p align="justify">

Al utilizar un compilador para .NET nos genera un archivo ProgramCS.exe que es el ensamblado ejecutable.

Igualmente, el compilador de VB nos genera un ensamblado ejecutable ProgramVB.exe.


Al ejecutar cualquiera de los dos ensamblados se muestra el siguiente resultado:
</p>
<img src="output.png">
<p align="justify">
Esto es porque ambos compiladores generan un ensamblado con codigo intermedio (Codigo IL) que ejecutara el interprete de .NET.

Como en la siguiente imagen:
</p>
<img src="compilationdotnet.png"/>
<p align="justify">
Los ensamblados se clasifican según su uso:

<b>Privados (Private Assembly)</b> son usados solamente por una aplicación, se instalan dentro del mismo directorio o subdirectorio que la aplicación y opcionalmente pueden o no ser firmados con un Strong name.

<b>Compartido (Shared Assembly)</b> Se usan por dos o más aplicaciones en una misma máquina, se instalan dentro del GAC (Global Assembly Cache) y deben ser obligatoriamente firmados por un Strong name.
o según el contenido.</br>
<b>Archivo único (Single-File Assembly)</b> Todo el contenido del ensamblado es empacado en un solo archivo con extensión (.dll) en caso de ser una biblioteca o con extensión (.exe) en caso de ser un ejecutable.</br>
<b>Múltiples archivos (Multifile Assembly)</b> Aquí el contenido del ensamblado está dividido en múltiples archivos, siendo estos de código IL o bien de otros recursos como imágenes o archivos XML.</br>
Los ensamblados únicamente pueden ser ejecutados por el CLR de .NET, por lo que si queremos que este ensamblado funcione en otra máquina esa máquina debe tener instalado Mono en el caso de GNU/Linux o bien Microsoft .NET en el caso de Windows.
</p>
<p align="justify">
En el caso de los códigos anteriores se generó para cada código un ensamblado privado (Private Assembly) y de archivo único (Single File Assembly).
</p>
