# 🧮 GraphExamples

Este proyecto es parte del sistema **GraphComputer**, una aplicación desarrollada en Windows Forms con C# que permite visualizar y manipular estructuras gráficas como polígonos, algoritmos de relleno y otras operaciones gráficas educativas. Es ideal para el aprendizaje de algoritmos gráficos y estructuras computacionales visuales.

## 🚀 Características principales

- 📐 Generación y visualización de polígonos regulares con un número configurable de lados.
- 🎨 Algoritmo de relleno (Flood Fill) con color dinámico seleccionado por el usuario.
- 🖱️ Interacción mediante clic del usuario sobre el lienzo (`PictureBox`) para activar algoritmos.
- ⌛ Visualización paso a paso de los algoritmos con temporización opcional.
- ⚙️ Estructura orientada a clases reutilizables y con separación clara de lógica.

## 🧱 Estructura del proyecto
|-- Config -> Contiene la configuración del proyecto, incluyendo la configuración de la aplicación y los recursos.
|-- Core -> Contiene la lógica central del proyecto, incluyendo la generación de polígonos los algoritmos para cada formulario.
|-- Structures -> Contiene las estructuras de datos utilizadas en el proyecto.
|-- Views -> Contiene las vistas de la aplicación, incluyendo el lienzo principal y los controles de usuario.
|-- assets -> Contiene recursos gráficos como  fondos.

## 📦 Dependencias
- .NET Framework 4.7.2 o superior
- Windows Forms para la interfaz gráfica.
- System.Drawing para operaciones gráficas.
- Guna.UI2 para componentes de interfaz de usuario avanzados.
- FontAwesome.Sharp para iconos y elementos visuales.

## 🖥️ Requisitos

- [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
- Visual Studio 2019 o superior (preferible)
- Sistema operativo: Windows

## ▶️ Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Cotbert2/GraphComputer.git
   cd GraphComputer/GraphExamples
   ```
