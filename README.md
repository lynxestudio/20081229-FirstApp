# First App
Entendiendo los ensamblados (assemblies)

Una de las características más atractivas que ofrece la programación con .NET es la posibilidad de poder construir aplicaciones con diferentes lenguajes, cada compilador para .NET genera un módulo ejecutable conocido como assembly (ensamblado) que contiene instrucciones en un lenguaje llamado CIL (Common Intermediate Language) que es ejecutado por el CLR (Common Language Runtime).

Examinemos pues el siguiente programa en código C#

Lo compilamos:

$ mcs ProgramCS.cs

Esto nos genera un archivo ProgramCS.exe que es el ensamblado ejecutable.
Ahora examinemos el mismo programa en código Visual Basic.

Lo compilamos:

$ vbnc ProgramVB.vb


Igualmente, el compilador de VB nos genera un ensamblado ejecutable ProgramVB.exe.
Al ejecutar cualquiera de los dos ensamblados se mostrará el siguiente resultado:

Los ensamblados se clasifican según su uso:

<b>Privados (Private Assembly)</b> son usados solamente por una aplicación, se instalan dentro del mismo directorio o subdirectorio que la aplicación y opcionalmente pueden o no ser firmados con un Strong name.

<b>Compartido (Shared Assembly)</b> Se usan por dos o más aplicaciones en una misma máquina, se instalan dentro del GAC (Global Assembly Cache) y deben ser obligatoriamente firmados por un Strong name.
o según el contenido.</br>
<b>Archivo único (Single-File Assembly)</b> Todo el contenido del ensamblado es empacado en un solo archivo con extensión (.dll) en caso de ser una biblioteca o con extensión (.exe) en caso de ser un ejecutable.</br>
<b>Múltiples archivos (Multifile Assembly)</b> Aquí el contenido del ensamblado está dividido en múltiples archivos, siendo estos de código IL o bien de otros recursos como imágenes o archivos XML.</br>
Los ensamblados únicamente pueden ser ejecutados por el CLR de .NET, por lo que si queremos que este ensamblado funcione en otra máquina esa máquina debe tener instalado Mono en el caso de GNU/Linux o bien Microsoft .NET en el caso de Windows.


En el caso de los códigos anteriores se generó para cada código un ensamblado privado (Private Assembly) y de archivo único (Single File Assembly).
