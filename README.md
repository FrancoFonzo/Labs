# Labs-2021

En este repositorio se encuentran todos los laboratorios utilizados en la asignatura Tecnologías de Desarrollo de Software IDE, materia electiva de la UTN FRRo.

|Índice|
|:-|
|:computer: [Pre-Requisitos](#Pre-Requisitos)|
|:briefcase: [Instrucciones Git](#Instrucciones-Git)|
|:cactus: [Git Working Tree](#El-Working-Tree-de-Git)|
|:bookmark_tabs: [Glosario](#Glosario)|
|:star2: [Extra](#Extra)|

## Pre-Requisitos

|Requisito|Descripción|Link|
|:-|:-|:-|
|Visual Studio .Net|Entorno para programar. Es deseable tener descargada la última versión|[https://visualstudio.microsoft.com/es/downloads/](https://visualstudio.microsoft.com/es/downloads/)|
|Git|Sistema de control de versiones distribuido. Multiplataforma y de codigo abierto|[https://git-scm.com/](https://git-scm.com/)|
|Usuario GitHub|Repositorios online|[https://github.com/join](https://github.com/join?ref_cta=Sign+up&ref_loc=header+logged+out&ref_page=%2F&source=header-home)|
|***[Recomendado/Opcional]*** GitKraken|Control de versiones con repositorios Git locales|[https://www.gitkraken.com/download](https://www.gitkraken.com/download)|

> Nota: La versión gratuita de GitKraken posee todo lo necesario a utilizar, pero existe para el que le guste la herramienta una versión premium con otras features como: Tener Boards estilo trello y calendarios, entre otras cosas. Se puede conseguir gratuitamente como alumno universitario, teniendo un correo @frro dado de alta en la universidad (Secretaría de Asuntos Universitarios).
> 
### Instalación Visual Studio Community

La parte complicada del proceso consiste en seleccionar que componentes de VS instalar, seleccionar:
![InstalacionNetComunity_P1](https://user-images.githubusercontent.com/41701343/112885224-e07a1480-90a6-11eb-9292-1a419aa3e7eb.png)
![InstalacionNetComunity_P2](https://user-images.githubusercontent.com/41701343/112885238-e53ec880-90a6-11eb-9b1e-e6f0fca5c57d.png)
Recordar destilar la opción de Azure Data Lake ya que esa herramienta no sera de utilidad en este curso

### Instalacion de componentes en caso de faltar alguno despues de la instalación

> [Documentacion oficial](https://docs.microsoft.com/es-es/visualstudio/install/modify-visual-studio?view=vs-2019)
1. Buscar Visual Studio Installer en la barra de búsqueda de aplicaciones sistema operativo utilizado
2. En la versión de VS utilizada, clickear en modificar
3. Si se desea instalar alguna carga de trabajo de las [mencionadas anteriormente](#Instalación-Visual-Studio-Community) clickear en la tab Cargas de Trabajo las correspondientes
4. [***Recomendado***] Si, en cambio se prefiere buscar por característica individual, ir a la tab Componentes Individuales (arriba al medio) y seleccionar las correspondientes. Ej. NET 5.0 Runtime

## Instrucciones Git
###### Si se desea tener una base teórica solida sobre Git antes de realizar la ejercitación consultar las secciones [`Git Working Tree`](#El-Working-Tree-de-Git) y [`Glosario`](#Glosario)
La forma de trabajo que se va a utilizar este año consiste en los siguientes pasos:
> Esta se encuentra inspirada por la forma de trabajo que fue implementada por otros adscriptos en otra materia electiva de la UTN llamada "Soporte a la Gestión de Datos con Programación Visual"

##### IMPORTANTE: Donde diga `practica-2021` remplazar por `Labs`
1. [Forkear](#Fork) el repositorio oficial de practica seleccionando su usuario de GitHub
![tutoGit_P0](https://user-images.githubusercontent.com/41701343/111100579-d2fd5000-8526-11eb-83a3-119c0b2ce18e.png)

2. [Clonar](#Clone) el repo forkeado
2.1. Primero copiar al portapapeles la dirección url de este
![tutoGit_P2](https://user-images.githubusercontent.com/41701343/111100784-4606c680-8527-11eb-8e96-e00ed107bb12.png)
2.2. Luego acceder a GitKraken y copiar la url anterior en el formulario de clonacion
![tutoGit_P3](https://user-images.githubusercontent.com/41701343/111100928-9aaa4180-8527-11eb-8d9b-548e5f562a36.png)
![tutoGit_P4](https://user-images.githubusercontent.com/41701343/111100985-ba416a00-8527-11eb-9099-341edb9c4c60.png)
***2.2b. En Visual Studio ir a *Git*/*Clonar Repositorio* y proceder de la misma forma***

3. Abrir la carpeta con Visual Studio desde el menú contextual (click derecho)
![tutoGit_P6](https://user-images.githubusercontent.com/41701343/111101096-f674ca80-8527-11eb-9518-2e316b3c6568.png)

4. Cambiar la ubicación predeterminada de los proyectos en Visual Studio
- Ingresar "ubic" en la *Barra de Búsqueda*
![tutoGit_P7](https://user-images.githubusercontent.com/41701343/111101162-16a48980-8528-11eb-8f06-77e28c36a81b.png)
- Cambiar la ubicación predeterminada a la dirección donde esta el repositorio clonado previamente
![tutoGit_P8](https://user-images.githubusercontent.com/41701343/111101168-1906e380-8528-11eb-928b-78e6c17394dc.png)

5. Ir a al menú desplegable en *Archivo*/*Nuevo*/*Proyecto*
![tutoGit_P9](https://user-images.githubusercontent.com/41701343/111101334-6f742200-8528-11eb-886f-e33286c1c9e5.png)
> Al seleccionar el tipo de proyecto revisar que en el titulo este no contenga `(Net Framework)`, ya que estos no permiten seleccionar a NET 5 o NET Core como motor de ejecución

6. Llenar el nombre del laboratorio en el campo *Nombre del Proyecto*, el campo *Nombre de la Solución* se ingresara automáticamente con el mismo valor. 
- Luego clickear en el selector de archivos correspondiente al campo *Ubicación*
![tutoGit_P10](https://user-images.githubusercontent.com/41701343/111101400-90d50e00-8528-11eb-9f25-9d2ea5fa675f.png)
- Ingresar la subcarpeta correspondiente a la unidad y el laboratorio en el que se quiera trabajar
![tutoGit_P11](https://user-images.githubusercontent.com/41701343/111101521-dc87b780-8528-11eb-9c76-e42978b920b3.png)

7. Seleccionar NET 5 en el menú de opciones. NOTA: Tener instalado el [runtime](#Instalacion-de-componentes-en-caso-de-faltar-alguno-despues-de-la-instalación)

8. Notar como los nuevos archivos se incluyen en el [Staging Area](#Staging-Area) (sección donde están los archivos marcados) al clickear en stage all changes
![tutoGit_P13](https://user-images.githubusercontent.com/41701343/111101580-faedb300-8528-11eb-88b8-d592ecd8b8f0.png)
***8.b. En VS ir a *Ver*/*Cambios de GIT****
![imagen](https://user-images.githubusercontent.com/41701343/112892379-9ba6ab80-90af-11eb-93ff-801881c83001.png)

9. ***[Recomendado/Opcional]*** Crear una nueva [branch](#Branch) con el siguiente formato: UnidadNLabZ con N y Z igual al numero de unidad y de laboratorio respectivamente
![tutoGit_P14](https://user-images.githubusercontent.com/41701343/111101723-41dba880-8529-11eb-97df-46b6864b6fcf.png)
***9.b. En VS ir a *Git*/*Nueva Rama****
> Es posible [commitear](#Commit) los cambios directamente en [main](#Master), sin embargo esta forma es utilizada si se esta trabajando en solitario, lo cual es bastante poco común

10. [Este paso se repite] [Commitear](#Commit) los cambios escribiendo un mensaje que represente lo realizado, como por ejemplo la inicializacion del proyecto con Visual Studio
![tutoGit_P15](https://user-images.githubusercontent.com/41701343/111101922-a991f380-8529-11eb-9119-cef1a468d9e4.png)
***10.b. En VS ir a *Ver*/*Cambios de GIT* (una vez desplegado se mantiene a la izquierda como opción)***

11. Observar como los commits en la [branch "main"](#Master) están tanto en [local](#Local) (símbolo notebook) como en [remoto](#Remote) (icono del usuario de GitHub). Para cambiar esto [pushear](#Push) los cambios a remoto con el siguiente botón
![tutoGit_P16](https://user-images.githubusercontent.com/41701343/111102098-0e4d4e00-852a-11eb-8c0c-8e009a2a0883.png)
***11.b. No hay equivalente en la UI de VS para GIT***

12. ***[Recomendado/Opcional]*** Una vez que se termino de trabajar con el laboratorio como se observa en la siguiente imagen: 
![tutoGit_P18](https://user-images.githubusercontent.com/41701343/112549216-33e51d80-8d9c-11eb-82ec-a1392966c2a1.png)
[mergear](#Merge) la [branch actual del ejercicio](#Branch) con la [branch main](#Branch) del [repositorio local](#Local), arrastrando la primera hacia la segunda
***12.b. En VS ir a *Ver*/*Repositorio de GIT* y hacer click derecho en la rama del ejercicio para que aparezca el menú desplegable, allí seleccionar la opción resaltada***
![imagen](https://user-images.githubusercontent.com/41701343/112893491-220fbd00-90b1-11eb-954b-f542c174ef6a.png)

13. Agregar el repositorio de la asignatura a [remote](#Remote), de manera de que pueda tener los ultimas actualizaciones a los ejercicios y sea capaz de realizar [pull requests](#Pull-Request) a este
![tutoGit_P17](https://user-images.githubusercontent.com/41701343/111102253-697f4080-852a-11eb-8c81-a59aed316325.png)
***13.b. En VS esto ya esta presente por default***

14. [Pullear](#Pull) los últimos cambios presentes en la branch [Main](#Master) del repositorio [remoto](#Remote) de la catedra y [mergear](#Merge) esta con la branch [Main](#Master) del repositorio forkeado local. ![Demostracion en vídeo](https://user-images.githubusercontent.com/41701343/112508562-6d069900-8d6e-11eb-9333-0835db176e1f.mp4)
***14.b. En VS ir a *Ver*/*Repositorio de GIT* y hacer click derecho en la rama main remota para que aparezca el menú desplegable, allí seleccionar la opción resaltada***
![imagen](https://user-images.githubusercontent.com/41701343/112894489-4fa93600-90b2-11eb-9fbe-27750a43c15e.png)
#### Feedback de alumnos
> Muchas gracias al alumno [Bruno Cocitto](https://github.com/brunococitto) por sus significativos aportes y solicitudes de cambios
Aquel que desee soliticitar agregar o cambiar algo, tenga dudas respecto a algun ejercicio o simplemente quiera probar como hacer una [Pull Request](#Pull-Request) puede hacer sus cambios en su fork y luego realizar una pr al repo de la catedra

15. De forma inversa a como se hace [merge](#Merge) en GitKraken arrastrar la [branch](#Branch) donde se esta trabajando hacia *Remote*/*NetUtnRosario*/*Main* y seleccionar en el menu contextual: `Push and start a pull request to NetUtnRosario/main`
***15.b. En VS se debe pushear los cambios realizados en la branch donde se este trabajando y luego es necesario ir al sitio del repositorio en GitHub. Ya que el complemento de GIT de VS no puede manejar estas acciones que no son propias de Git en si, sino de la plataforma GitHub***
![imagen](https://user-images.githubusercontent.com/41701343/116576065-3841b080-a8dd-11eb-85e3-60a6e65087f8.png)
## El Working Tree de Git
![git_working_tree](https://user-images.githubusercontent.com/44505076/111569584-b4df5c00-8781-11eb-8ee4-6c2c00ccb8cd.png)

La carpeta real de archivos físicos se denomina [Working Directory](#Working-Directory) (también denominado `Workspace`). Al [clonar](#Clone) de Internet un repositorio (ejemplo de GitHub u otra plataforma) o realizar la tarea manual de descargarlo, descomprimirlo e inicializarlo (que es equivalente) estamos generando un [Repositorio Local](#Local) que representa de forma logica nuestro [Working Directory](#Working-Directory). Si escribimos nuevo código, git trackea (nota) las diferencias en los archivos con respecto al último cambio almacenado en [local](#Local). Para que nuestros cambios físicos (crear, modificar o eliminar algun archivo) se almacenen efectivamente en el [repositorio local](#Local), se debe realizar un [commit](#Commit) (que es un contenedor con los cambios que realizamos, junto a un ID, el autor de los cambios y una fecha). El repositorio local se maneja 100% con [commits](#Commit).

Cuando hay cambios en algunos archivos, pero estos aún no han sido incluidos en un [commit](#Commit), estos estan en el [Staging Area](#Staging-Area) (que representa a todos los archivos que git detectó una diferencia con respecto al último [commit](#Commit) que posee en nuestro repositorio local). Con lo que está allí podemos realizar un [commit](#Commit) para que sea agregado oficialmente a nuestro repo local o remover estos cambios de este area y dejar los archivos como estaban antes.

El repositorio que se encuentra almacenado en GitHub (u otra plataforma) para todos los miembros del equipo se denomina [Repositorio Remoto](#Remote), referenciado como ***Origin***. Git también rastrea la diferencia entre nuestro repositorio local y el remoto. Es posible traer ([pull](#Pull)) al [repositorio local](#Local) los [commits](#Commit) que hayan subido al [remoto](#Remote) otros compañeros, así como subir ([push](#Push)) [commits](#Commit) en el sentido inverso al anterior y mantenernos sincronizados.

## Glosario

### Control de Versiones
> Gestión de los cambios que se le realizan al código, puede ser manual (utilizando prefijos vN.M y guardando los archivos iterativamente en el equipo o en Google Drive, por ejemplo) o utilizando alguna herramienta que lo facilite ([Git](#Git) en este caso).

### Git
> Sistema de control de versiones distribuido, esto significa que sirve para gestionar los cambios en el código de forma local y en un repositorio remoto que es ejecutado en un servidor central. Es gratis y de codigo abierto. Web para descargar: https://git-scm.com/.

### Repositorio
> Almacenamiento virtual de tu proyecto. Permite guardar versiones del código a las que es posible acceder cuando se necesite.

### Local
> Es el repositorio local manejado por cada desarrollador en sus equipos personales. Se comunica con el repositorio remoto alojado en GitHub mediante un área intermediaria a la cual denominaremos [Staging Area](#Staging Area), en donde se envían [commits](##Commit) con [push](#Push) y reciben de los demás integrantes del equipo que hayan subido sus [commits](#Commit) con [pull](#Pull).

### Remote
> Refiere al repositorio central que es ejecutado en un servidor con determinado nivel acceso para cada uno de los desarrolladores. Es el repositorio que almacena GitHub en sus servidores y al cual se le realiza [push](#Push) para enviar [commits](#Commit) y [pull](#Pull) para traer [commits](#Commit) de los demás integrantes del equipo.

### Working Directory
> Suele tomarse como sinónimo de repositorio local, lo cual es incorrecto. El Working Directory representa los archivos físicos reales en del equipo, mientras que el repositorio local es una representación virtual del mismo. Cuando haya cambios nuevos locales mientras se escribe nuevo código, Git trackea estos cambios comparando el Working Directory con el repositorio local.

### Master/Main
> [Branch](#Branch) principal del repositorio, en esta generalmente se cuenta con la versión más estable del código. Una forma recomendada de trabajar es hacer una branch por cada nuevo requerimiento o caso de uso que se esté trabajando y subir los [commits](#Commit) allí, para una vez terminado pasarlos a "[master](#Master/Main)" (mediante un merge directo o una [Pull Request](#Pull Request) en donde otros contribuidores deben aprobar los cambios antes). Nota: desde 2020 en Git se reemplazó la branch [master](#Master/Main) por “[main](#Master/Main)”. Solo los repositorios creados posteriormente a 2020 poseen este cambio.

### Tracking
> Tarea que realiza Git, que consiste en rastrear los cambios nuevos que se realizaron al escribir nuevo código con respecto a los archivos locales y a su vez que con respecto al repositorio remoto. El tracking será de archivos nuevos, modificaciones o eliminaciones.

### Gitignore
> Se puede crear un archivo llamado "[.gitignore](#Gitiginore)" e incluir alli archivos o carpetas a forma de "blacklist", es decir, lo que esté ahí dentro será ignorado por Git y no almacenará información de esos archivos (no habrá tracking). Por ejemplo, los archivos generados por programas del tipo IDE, como Visual Studio.

### Tu Identidad
> Lo primero que deberás hacer cuando instales Git, es establecer tu nombre de usuario y dirección de correo electrónico. Esto es importante porque los "[commits](#Commit)" de Git usan esta información, y es introducida de manera inmutable en los [commits](#Commit) que envías:
```
$ git config --global user.name "John Doe"
$ git config --global user.email johndoe@example.com
```
> De nuevo, sólo necesitas hacer esto una vez si especificas la opción --global, ya que Git siempre usará esta información para todo lo que hagas en ese sistema. Si quieres sobrescribir esta información con otro nombre o dirección de correo para proyectos específicos, puedes ejecutar el comando sin la opción --global cuando estés en ese proyecto.

### Inicializar Repositorio
> Para comenzar el seguimiento de un proyecto, debes ir al directorio del proyecto y usar el comando:  $ git init. Esto crea un subdirectorio nuevo llamado “.git”, el cual contiene todos los archivos necesarios del repositorio. Todavía no hay nada en tu proyecto que esté bajo seguimiento. Si deseas empezar a controlar versiones de archivos existentes (a diferencia de un directorio vacío), deberías comenzar el seguimiento de esos archivos y hacer una confirmación inicial. Puedes hacerlo con `git add` para especificar qué archivos quieres controlar, seguidos de un `git commit` para confirmar los cambios.

### Fork
> Generar un repositorio bifurcado que está asociado tanto al repositorio original como al propio. Permite probar cambios que no son deseables de hacer en el original y a la vez mantenerse al día con los cambios que puedan surgir allí.

### Clone 
> Se realiza una copia del repositorio clonado. Se debe copiar la dirección URL del repositorio que se quiere clonar con `git clone [url]`. Un ejemplo sería: encontrar un repositorio interesante en GitHub y para tenerlo localmente en el equipo, en vez de descargarlo manualmente, se clona a través de su dirección URL y se genera el repositorio local directamente.

### Staging Area
> Área de ensayo donde se almacenan los archivos con cambios, de forma temporal, que se agregaron a está. Son cambios locales que aún no han sido incluidos en un commit y por lo tanto no podemos enviarlos aún a nuestro repositorio remoto.

### Add
> Cuando se cuenta con un archivo nuevo o algun tipo de cambio que no esta contenido en el [Staging Area](#Staging Area), es posible agregarlo a esta última mediante git add \<nombreArchivo>. Si se quiere agregar todos los cambios, se utiliza `git add .`. Si se requiere agregar todos los cambios excepto archivos nuevos a la staging area, se usa `git add -u`.

### Commit
> Información que contiene los nuevos cambios que se realizaron en el código, quien lo realizó, un ID y la fecha. Al realizar [commits](#Commit), se les puede subir al repositorio remoto compartido, mediante `git push origin \<nombreBranch>`. También es posible traer los [commits](#Commit) que realizaron otros miembros del equipo y subieron al remoto, mediante `git pull`. Tener en cuenta que [push](#Push) y [pull](#Pull) funcionan por [branch](#Branch), por lo que si se quiere es traer o enviar [commits](#Commit) a otras [branches](#Branch), se debe cambiar de [branch](#Branch) haciendo `git checkout \<nombreBranch>`.

### Push
> Subir los [commits](#Commit) realizados en el repositorio local al repositorio remoto mediante `git push origin \<nombreBranch>`. Solo sube al remoto los que detecte en la rama actual, ya que “origin” hace referencia a la rama de origin/actual.

### Branch
> Cuando se necesite realizar cambios como nuevas features, es recomendable que esto se realice en una “sección propia” o rama bifurcada desde algún punto de partida (commit específico) a donde subir los cambios, de modo de que estos sean visibles para los demás en el repositorio remoto. Estos cambios no se ven reflejados en [main](#Master/Main) del repositorio hasta que se realice un [merge](#Merge) de la [branch](#Branch) hacia [main](#Master/Main). Ejemplo: codificar una feature llamada “Login”, se crea una rama “login_user” y se suben/[pushean](#Push) los cambios allí. Cuando se termina de trabajar con la feature, se hace un [merge](#Merge) de la [branch](#Branch) login_user a [main](#Master/Main) y de esta forma todos nuestros cambios serán enviados al [main](#Master/Main) del proyecto.

### Merge
> Agregar los cambios presentes en una [branch](#Branch) determinada, a otra [branch](#Branch). Ejemplo: los [commits](#Commit) realizados en "register_user" se desean que estén en [master](#Master/Main) porque se finalizó el trabajo, entonces se "combinan" los [commits](#Commit) de register_user en [master](#Master/Main). Para esto: `git merge \<notMasterBranch>`.

### Pull
> Para actualizar nuestro repositorio local, con los commit realizados en el repositorio remoto, se utiliza el comando `git pull`, que descarga los [commits](#Commit) nuevos en el repo remoto que no están en el repositorio local, así mantenemos nuestro repo local sincronizado. Solo trae los cambios que detecta en la rama actual. Podría decirse que un [pull](#Pull) es un [fetch](#Fetch) + un [merge](#Merge) a nuestros archivos locales.

### Pull Request
> Se podría llamar “Merge Request” que es más exacto. Es una solicitud que realiza un integrante del equipo hacia los demás, pidiendo agregar los cambios realizados en una determinada [branch](#Branch), a otra. Esto se gestiona por determinados usuarios revisores que pueden optar por aprobar lo realizado, hacer comentarios para requerir cambios o preguntas para aclarar porqué se procedió de determinada manera. Los comentarios se realizan online en Github, y pueden ser comentarios generales, por archivo o por línea. Una vez que los reviewers aprueban los cambios, se acepta la [Pull Request](#Pull Request) y los [commits](#Commit) nuevos se combinan (por default) a la [branch](#Branch) correspondiente.

### Commits Log
> Historial de [commits](#Commit). Cada repositorio tiene uno. Muestra el historial de los [commits](#Commit) con autores, cambios y fechas. Todos los cambios que se hagan en el repositorio son guardados automáticamente en el log. Puede accederse a él mediante `git log` o `git log --oneline` para una versión simplificada.

### Commits Tree
> Ver el Historial de [commits](#Commit) del repositorio ([Commits Log](#Commits Log) como un árbol con sus ramificaciones ([branches](#Branch)). 

### HEAD
> Posición en la que se encuentra actualmente en el Commit Tree. Por default siempre que se haga [pull](#Pull) se estará viendo hasta el último de los [commits](#Commit), pero podemos "volver atrás" versiones del código desplazando el "HEAD" hacia otro punto de la historia. Mover el HEAD no borra ni crea [commits](#Commit) nuevos, por sí mismo no es una operación peligrosa en absoluto.

### Status
> Ver el estado general del repositorio local en la [branch](#Branch) actual, con respecto a remoto. Muestra en que [branch](#Branch) se encuentra, cuantos [commits](#Commit) hay, cuantos cambios se presentan en la "[Staging Area](#Staging Area)", etc... GitKraken ofrece esta información de forma visual en la vista principal del repositorio, pero por consola se debería escribir `git status`.

### Tags
> Git tiene la posibilidad de “etiquetar” puntos específicos ([commits](#Commit)) del repositorio. Esto se usa generalmente para marcar versiones (v1.0.0, por ejemplo). Para listar las etiquetas del repositorio se utiliza `git tag`. Para crear una etiqueta su utiliza `git tag -a \<aliasVersion> -m '\<mensaje>'`. Esta etiqueta se crea para el punto actual del repositorio. Para crear [tags](#Tags) desde [commits](#Commit) anteriores se usa el comando: `git tag -a \<aliasVersion> -m '\<mensaje>' \<codigoCommit>`.

### Reset
> Si se quiere deshacer cambios locales que aún no se han enviado al repositorio remoto, es posible realizar un "[reset](#Reset)" de nuestros cambios. El [reset](#Reset) puede revertir uno o más [commits](#Commit) locales. Hay 3 tipos de [reset](#Reset). El `git reset --soft` que solamente mueve "HEAD" hacia atrás sin borrar los cambios, es solo para ver nuestro código en una versión anterior antes de los cambios; el `git reset --mixed` (el default) que borrará la cantidad de [commits](#Commit) que le indiquemos, pero los cambios no se pierden, sino que se vuelven al "[Staging Area](#Staging Area)" y se dejará hacer nuevos [commits](#Commit); y el `git reset --hard` que es peligroso pues borra directamente la cantidad de [commits](#Commit) solicitados y estos se "pierden para siempre".

### Stash
> El comando `git stash` almacena temporalmente (o guarda en un [stash](#Stash)) los cambios que hayas efectuado en el código en el que estás trabajando para que puedas trabajar en otra cosa (cambiar de rama) y, más tarde, regresar y aplicar los cambios. Más adelante si son necesarios nuevamente en la misma [branch](#Branch) u otra, se realiza un `git stash pop` que recupera el código y lo coloca devuelta en [Staging Area](#Staging Area). También puedes usar `git stash apply` para aplicar los cambios y mantenerlos en el [stash](#Stash), esto resulta útil si necesitas aplicar los cambios en varias ramas.

### Fetch
> Con `git fetch` puedes traer los cambios del repositorio remoto al local en una nueva rama oculta llamada origin/main, por lo que no reemplaza los archivos físicos. Esto es para visualizar los cambios, pero sin reemplazarlos aún (a diferencia de [pull](#Pull)), pues a lo mejor se quiere hacer otra tarea antes de reemplazarlos. Para luego aplicar los cambios, se debe hacer un `git merge origin/main`.

### Rebase
> Un [rebase](#Rebase) modifica la historia de [commits](#Commit) del repositorio, por lo tanto, es peligroso. Tal vez se necesite por ejemplo cuando se crean [commits](#Commit) incorrectos y se quiere cambiarlos, pero estos ya están subidos al repositorio remoto con [push](#Push). Con [rebase](#Rebase) se puede cambiar el nombre de [commits](#Commit) en remoto, unificar los diferentes en uno, o borrarlos, entre otras cosas. Estando en la [branch](#Branch) en la que se desea modificar esto (se recomienda antes crear otra [branch](#Branch) desde el ultimo commit para tener una "copia de seguridad") se debe escribir `git rebase -i HEAD~n`, donde n se debe reemplazar por la cantidad de [commits](#Commit) que van a ser afectados por el [rebase](#Rebase), y la -i indica que será un [rebase](#Rebase) interactivo (da instrucciones de que se puede hacer con cada commit, sea unificar, renombrar, borrar, etc. 

### Recomendaciones:
> - En caso de trabajar en un proyecto en equipo, antes de comenzar a realizar cambios, se recomienda hacer un `git pull` para actualizar nuestro repositorio local en caso de que se hayan hecho nuevos cambios en el repositorio remoto.
> - Usar archivo [.gitignore](#Gitiginore) para no trackear archivos irrelevantes, como los generados por un IDE.
> - Al comenzar a trabajar en una nueva feature, es preferible creando una nueva rama, así no modificamos la rama principal en caso de “errores”, una vez terminada, hacer un [merge](#Merge).
