# Elementos

**_Elementos_** es un pequeño juego interactivo de Realidad Aumentada programado en Unity 5.5.0 haciendo uso de  
la Herramienta ARToolKit para Realidad Aumentada. Este juego fue presentado como el primer proyecto de 
la asignatura _Tópicos Especiales en Realidad Aumentada_ de la Universidad Simón Bolívar durante el 
trimestre Enero - Marzo 2017.

## Características y Funcionalidades

La funcionalidad principal consiste en el reconocimiento de marcas que representan los cuatro elementos
básicos (**Agua**, **Tierra**, **Fuego** y **Aire**) y dos marcas que representan **Unión**.

Inicialmente, el usuario puede elegir dos de estos cuatro elementos básicos y unirlos en una de las
marcas de _Unión_ para formar un nuevo elemento. El elemento creado nuevamente debe debe ser pasado a 
la segunda carta  _Unión_ con la finalidad de ser fusionado con un tercer elemento y así, hasta poder 
obtener nuevos elementos.

Este juego, trabaja con un sistema de interacción directa, puesto que el usuario representa un
agente y el juego una colección pasiva de objetos que esperan a ser manipulados por dicho usuario. Así mismo, 
está basada en la interacción educativa, ya que el usuario podrá crear elementos a partir de los básicos y conocer
de una manera divertida como se crean materiales reales como la Cerámica o el Vidrio.

## Elementos

Al 15/02 del 2017 Existe un total de 19 elementos, de los cuales 4 son los básicos y los 15 restantes
se pueden crear mendiante combinaciones. 

**Básicos:**  Agua, Tierra, Fuego, Aire.

**Combinaciones:** Lava, Humo, Vapor, Hielo, Polvo, Lodo, Nieve, Piedra, Arcilla, Nubes, Arena, Ceniza, Vidrio,
 Lluvia y Cerámica.

## Marcas

Aquí se pueden ver las 4 marcas principales del juego:

![alt text](https://github.com/leotms/Elementos/blob/master/Marcas/water-long.png?raw=true "Agua")
![alt text](https://github.com/leotms/Elementos/blob/master/Marcas/earth-long.png?raw=true "Tierra")
![alt text](https://github.com/leotms/Elementos/blob/master/Marcas/fuego-long.png?raw=true "Fuego")
![alt text](https://github.com/leotms/Elementos/blob/master/Marcas/air-long.png?raw=true "Aire")

Y las marcas de Unión:

![alt text](https://github.com/leotms/Elementos/blob/master/Marcas/Union-long.png?raw=true "Union")
![alt text](https://github.com/leotms/Elementos/blob/master/Marcas/Union2-long.png?raw=true "Union")

El set de imágenes para el reconocimiento está incluido en este repositorio en el directorio de `Marcas`. 


## Instalación y Prueba

Este repositorio contiene el código fuente necesario. Se recomienda el uso de Unity 5.5.0, no se ha probado la compatibilidad
del código en versiones anteriores, aunque la libreria ARToolKit puede usarse apartir de Unity 5.3.2 según el sitio oficial.

Basta clonar o descargar el código fuente e importar el proyecto desde Unity. Una vez abierto el proyecto, debe abrirse la
escena principal: `Scenes/CombineElements`.

El equipo debe disponer de cámara frontal y las marcas deben estar correctamente impresas sobre papel blanco. Para las pruebas
es necesario tomar en cuenta factores como la luz o el brillo que puedan evitar el correcto reconocimiento de las marcas.

El paquete de ARToolKit ya se encuentra incluido en este repositorio y no hace falta descargarlo o importarlo nuevamente.

## Autores
- [Cinthya Ramos.](https://github.com/CinthyaRamos)
- [Patricia Valencia.](https://github.com/patriv)
- [Leonardo Martínez.](https://github.com/leotms)


## Enlaces Externos
- [Unity](https://unity3d.com/es)
- [ARToolKit](https://artoolkit.org)

## Última Modificación: 
15 de Febrero, 2017.
