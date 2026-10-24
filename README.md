# 🚀 Billy-App

> Application de bureau .NET (Windows Forms) développée pour le contrôle, la communication et la gestion du projet **Billy CubeSat** (Billy-SpaceTeam).

---

## ✨ Fonctionnalités principales

* **🔌 Connexion multi-modes :**
  * Communication série (UART / Port COM) pour le dialogue direct avec les cartes STM32 Nucleo.
  * Connexion réseau (TCP/IP / Wi-Fi) pour le suivi des données à distance.
* **⚡ Flashage et Transfert de firmware :**
  * Détection automatique des cartes STM32 Nucleo connectées en USB.
  * Transfert et flashage de fichiers binaires (`.bin`) avec suivi de progression en temps réel.
* **🎨 Interface adaptative & Paramètres :**
  * Basculement dynamique entre le **Thème Clair** et le **Thème Sombre** (avec sauvegarde des préférences utilisateur).
  * Gestion centralisée des configurations (ports, débits, adresses IP, chemins de données).
* **🔄 Système de mise à jour intégré :**
  * Vérification automatique des nouvelles versions directement depuis les Releases GitHub.
  * Téléchargement et installation transparente des mises à jour de l'application.

---

## 🛠️ Technologies utilisées

* **Langage :** C# (.NET 8 / Windows Forms)
* **Matériel ciblé :** STM32 Nucleo (via ST-Link / USB & Wi-Fi)

---

## 🚀 Installation & Utilisation

1. Rendez-vous dans l'onglet [Releases](https://github.com/Billy-SpaceTeam/Billy-App/releases) du dépôt.
2. Téléchargez la dernière archive ZIP disponible (`Billy-App.zip`).
3. Extrayez le contenu dans le dossier de votre choix.
4. Lancez l'exécutable `Billy-App.exe`.

---

## 🔄 Compilation & Développement (Pour les contributeurs)

1. Clonez le dépôt :
   ```bash
   git clone [https://github.com/Billy-SpaceTeam/Billy-App.git](https://github.com/Billy-SpaceTeam/Billy-App.git)
