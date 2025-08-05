
# 📦 Sistema de Gestão de Centros de Distribuição (CD)

## 🎯 Objetivo
Gerenciar entrada e saída de mercadorias entre Centros de Distribuição (CDs) e destinos (filiais, clientes ou hubs), com apoio de APIs externas para CEP, distâncias e dados geográficos.

## 👥 Perfis de Usuário
- **Admin**: gerencia todos os CDs, usuários e relatórios.
- **OperadorCD**: registra entrada/saída de cargas, visualiza estoque do seu CD.
- **Motorista**: visualiza suas entregas e detalhes de rota.

## 📦 Funcionalidades Principais

### 🔐 Autenticação
- Login com JWT
- Controle de acesso por roles
- Registro e redefinição de senha

### 🏢 Gestão de CDs e Estoques
- CRUD de CDs (nome, endereço, cidade, UF)
- Cada CD possui um estoque por produto
- Registro de entradas e saídas de mercadorias

### 🚚 Movimentações
- Registro de transferências entre CDs
- Registro de entregas para destinos finais
- Acompanhamento de status da movimentação

### 🌍 Integração com APIs externas
- [ViaCEP](https://viacep.com.br): Autocompletar cidade/UF ao digitar CEP
- [OpenRouteService](https://openrouteservice.org/): cálculo de distância
- [IBGE API](https://servicodados.ibge.gov.br/api/docs/localidades): dados demográficos (opcional)

### 📊 Dashboards e Relatórios
- Estoque por CD
- Relatórios de movimentações por período
- Mapa com visualização de CDs e rotas
- Gráficos de movimentações por tipo e destino

## 🧱 Estrutura Técnica

### Backend (.NET 8)
- ASP.NET Core Web API
- NHibernate
- PostgreSQL
- Integração com APIs externas
- Swagger

### Frontend (React)
- React + Vite
- Mapa (Leaflet ou Google Maps)
- Gráficos com Recharts

---

## 📌 Próximos Passos
- [ ] Estrutura inicial do backend
- [ ] Integração com ViaCEP e OpenRouteService
- [ ] Frontend com login e painel inicial
- [ ] Dashboard de movimentações
