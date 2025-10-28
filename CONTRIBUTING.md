# Guía de Contribución

Gracias por tu interés en contribuir 💙  
Este documento explica las normas y buenas prácticas para colaborar en el proyecto.

## 🚀 Flujo de trabajo
1. Crea una rama desde `develop`:
   ```bash
   git checkout -b feature/nombre-de-tu-feature
   ```
2. Realiza tus cambios y asegúrate de seguir las convenciones del código.
3. Ejecuta las pruebas locales antes de hacer commit.
4. Haz un **pull request (PR)** hacia `develop` y solicita revisión.

## 💻 Estilo de código
- **Backend:** Sigue la guía de estilo de NestJS (estructura modular, servicios inyectables).
- **Frontend:** Sigue las convenciones de React y Tailwind (componentes reutilizables, hooks claros).
- Usa **camelCase** para variables y **PascalCase** para componentes.

## 🧪 Commits
Usa el formato de commits semánticos:
```
feat: agrega la conexión al ambiente de pruebas del SRI
fix: corrige error en validación de RUC
chore: ajusta dependencias del backend
docs: actualiza el README con nuevas instrucciones
```

## 🧰 Testing
- Todo nuevo módulo debe incluir pruebas unitarias.
- Asegúrate de mantener una cobertura mínima del 70%.

## ⚖️ Código de conducta
Sé respetuoso, empático y colaborativo.  
El objetivo es aprender, mejorar y crear juntos un proyecto sólido.

---
> Cualquier duda o sugerencia puede ser tratada mediante issues o discusiones en el repositorio.
