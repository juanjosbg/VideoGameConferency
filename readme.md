# Motor a usar para el desarrollo del VideoJuego (Motor of Video Game)
![Image text](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.3Up2WB81IejSSnsbgJYaIwHaE8%26pid%3DApi&f=1)


***

> ### Almacenamiento de las images (cloudinary)
> ![cloudinary](https://user-images.githubusercontent.com/42915483/184726339-de8987b5-f072-4758-8584-ecc03eb3e7ea.png)

---

## Herramientas a utilizar para la realización y elaboración del proyecto (Creation of Video Game)
### Table of Contents
1. Descargar Unity
2. Recursos a usar
   * version a trabajar en Unity
   * Sprites / Assets
   * Creación de las paletas
3. Creación del VideoJuego
   * Pautas
   * Confugirar el espacio de trabajo
   * Convertir de single a multiple imgs 
4. Importaciones
    * Effectos de sonidos
    * Musica de ambiente
5. Apuntes importantes
    * Parte del codigo
6. VideoJuego Terminado
    * [Repo en GITGUB](https://github.com/juanjosbg/VideoGamePromotional)


***
### 1.
Instalamos el motor a usar en este caso:
[Unity](https://unity3d.com/get-unity/download)

***
### 2.
#### `trabajar en Unity`
Despues de concluir el paso anterior (instalación de unity), instalamos la version con la cual deseamos trabajar, 
para ello arimos unity, nos vamos a la parte donde dice installs, y nos vamos donde dice instalar editor o Add y ahí escogemos la version en la cual se desea trabajar. 

#### Ejemplo
> ![InstallVersion](https://res.cloudinary.com/auo/image/upload/v1660603676/2.1.1_bzbdjg.png)
> ![SeleccionDeLaVersion](https://res.cloudinary.com/auo/image/upload/v1660603827/2.1.1_b5dgkq.png)


---
#### `Sprites / Assets`
Para la ejecución de nuestro proyecto nos dirigimos al enlace añadido, el cual contendra todo lo que se realizara en la creación del videojuego.

Despues de descargar y descomprimr los ficheros, del (`JoJo Jungle`) nos quedamos solo con la carpeta de `SpriteSheets` y esta es la que se le pasara al proyecto, y del otro (`JoJoJambo`) solo nos quedamos con la carpeta de `Sonidos o Effectos de sonidos`
#### Link 
> [UnJojo Jamboity](https://didigameboy.itch.io/jambo-jungle-free-sprites-asset-pack)
> ![DownloadThisVersion](https://res.cloudinary.com/auo/image/upload/v1660604266/version_wx3zel.png)


---
#### `Creación de las paletas`

***
### 3.
#### Convertir de single a multiple imgs
para convertir las imagenes que se estan a grupadas se pasaran de single a multiple y posterior a esto se le da en Sprite Editor.
![Ejem](https://res.cloudinary.com/auo/image/upload/v1661268222/mul_d9xdq6.png)

posteriro a esto pasamos del `filter Mode` `Bilinear` a `Point`
![Ejem](https://res.cloudinary.com/auo/image/upload/v1661269590/mul1_czity3.png)

Todo esto para facilitar que de una agrupacion de `IMG` se pueda separar y asi poder escoger o animarlas acorde al interes de cada uno.


***
### 5. Convertir de single a multiple imgs 
Para Convertir las imagenes que tenemos de recurso en nuestra carpeta de (`SpriteSheets / Player`)
realizamos los siguentes pasos
1. seleccionamos la img que deseamos convertir `La agrupación`
   Pasamos la imagen de `Single` a `Multiple` y luego le damos en `Sprite Editor`
   ![Ejem](https://res.cloudinary.com/auo/image/upload/v1660679320/Logo-front_tkjlpn.png)

   Despues de realizar el paso anterior, se nos abrira una nueva ventana 
    

### 4. Creación de las paletas

### 5. codigo

la variable `float` son valores reales es decir dato que representa la aproximación de un número real.


### 6. Apuntes importantes
La representacion de las fisicas en un motor de videoJuego 2D se representan mediante (Rigibody 2D)
