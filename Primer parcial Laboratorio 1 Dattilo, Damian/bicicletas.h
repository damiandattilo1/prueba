#ifndef MOTOS_H_INCLUDED
#define MOTOS_H_INCLUDED




typedef struct
{
	int id;
	char descripcion[20];
}eTipo;

typedef struct
{
	int id;
	char nombreColor[20];
}eColor;

typedef struct
{
	int id;
	char marca[20];
	int idTipo;
	int idColor;
	float rodado;
	int isEmpty;
}eBici;

typedef struct
{
	int id;
	char descripcion[25];
	int precio;
}eServicio;





#endif // MOTOS_H_INCLUDED

/** \brief Inicializa un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return 1 si hubo un error, 0 si exitoso
 *
 */

int inicializarBicis(eBici bicis[], int tam);

/** \brief da de alta un elemento en un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return 1 si error, 0 si exitoso
 *
 */

int altaBici(eBici bicis[], int tam, int id);

/** \brief modifica un elemento en un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return 1 si error, 0 si exitoso
 *
 */

int modificarBici(eBici bicis[], int tam);

/** \brief da de baja un elemento en un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return 1 si error, 0 si exitoso y 2 si el usuario cancela la baja
 *
 */

int bajaBici(eBici bicis[], int tam);

/** \brief imprime un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return 1 si error, 0 si exitoso
 *
 */

int mostrarBicis(eBici bicis[], int tam);

/** \brief imprime un elemento en un arreglo de bicis
 *
 * \param elemento
 *
 */

void mostrarBici(eBici unaBici);

/** \brief busca un elemento libre en un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return la posicion del elemento o -1 si arreglo completo
 *
 */

int buscarLibre(eBici bicis[], int tam);

/** \brief busca un elemento por Id en un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \param id del elemento a buscar
 * \return el indice del elemento o -1 si el Id no existe
 *
 */

int buscarBici(eBici bicis[], int tam, int id);

/** \brief imprime un arreglo de colores
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return -1 si error, o si OK
 *
 */

int mostrarColores(eColor array[],int tam);

/** \brief imprime un elemento de un arreglo de colores
 *
 * \param elemento
 *
 */

void mostrarColor(eColor unColor);

/** \brief imprime un arreglo de tipos
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return -1 si error, o si OK
 *
 */

int mostrarTipos(eTipo array[],int tam);

/** \brief imprime un elemento de un arreglo de tipos
 *
 * \param elemento
 *
 */

void mostrarTipo(eTipo unTipo);

/** \brief imprime un arreglo de servicios
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return -1 si error, o si OK
 *
 */

int mostrarServicios(eServicio array[],int tam);

/** \brief imprime un elemento de un arreglo de servicios
 *
 * \param elemento
 *
 */

void mostrarServicio(eServicio unServicio);

/** \brief hardcodea un arreglo de bicis
 *
 * \param arreglo
 * \param tama�o del arreglo
 * \return cantidad de elementos a hardcodear
 *
 */

int hardcodearBicis(eBici bicis[], int tam, int cant);
