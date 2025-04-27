
# 💼 GatePayNavieras - Sistema de Gestión de Pagos Gate In

### 🧾 Descripción del negocio

**GatePayNavieras** es un sistema de escritorio diseñado para gestionar los pagos de gate-in para transportistas en plataformas de navieras como **MSC**, **MAERSK** y **HAPAG LLOYD**. El sistema permite representar a clientes (transportistas o empresas) en la facturación de gate-in, facilitando el proceso de validación de pagos y envío de comprobantes.

### 🎯 Funcionalidades iniciales

- Registro de clientes (transportistas o representantes).
- Registro y control de facturas descargadas desde plataformas de navieras.
- Historial de pagos y estados.
- Control de envíos de facturas a los clientes.
- Automatización de descarga de facturas usando Selenium.
  
---

## 🧱 Entidades tentativas

### 1. Cliente
| Campo | Tipo | Descripción |
|-------|------|-------------|
| IdCliente | int | Identificador único |
| NombreCompleto | string | Nombre y apellido del cliente |
| TipoDocumento | string | DNI, RUC, etc. |
| NumeroDocumento | string | Número de documento |
| Telefono | string | Teléfono o WhatsApp |
| Correo | string | Correo electrónico |

### 2. Factura
| Campo | Tipo | Descripción |
|-------|------|-------------|
| IdFactura | int | Identificador único |
| IdCliente | int | Relación con el cliente |
| Naviera | string | Nombre de la naviera (MSC, MAERSK, HAPAG) |
| FechaPago | DateTime | Fecha en que se realizó el pago |
| Monto | decimal | Monto de la factura |
| EstadoEnvio | string | Si fue enviada al cliente (Pendiente, Enviado) |
| ArchivoFactura | string | Ruta del PDF descargado |

### 3. Pago
| Campo | Tipo | Descripción |
|-------|------|-------------|
| IdPago | int | Identificador único |
| IdFactura | int | Relación con la factura |
| MetodoPago | string | Kipu, Transferencia |
| FechaRegistro | DateTime | Fecha en que se registró el pago |
| ComprobantePDF | string | Ruta al archivo del comprobante (opcional) |

---

## 🛠️ Estructura del Proyecto

- `LabGatePayNavieras` → Base de datos (script DDL)
- `CadGatePayNavieras` → Capa de Acceso a Datos
- `ClnGatePayNavieras` → Capa de Lógica de Negocios
- `CpGatePayNavieras` → Capa de Presentación (Windows Forms)
