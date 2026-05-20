# 🫶 MyelomaCareGuard(MVP)

A simple, warm, and accessible chronic disease management app designed for families to support elderly parents.

CareGuard combines health tracking, reminders, and gentle daily support — inspired by apps like Apple Health, but built with a caregiver-first mindset.

---

# 🎯 Vision

> “Help families stay on top of elderly health with clarity, simplicity, and care.”

This app focuses on:

* Clear health tracking 📊
* Easy report storage 📄
* Never missing appointments ⏰
* Gentle daily guidance 🍽️

---

# 🚀 MVP Scope (1 Month)

This project is intentionally scoped as a **Minimum Viable Product (MVP)** that can be built and used within 1 month.

---

## ✅ Core Features

### 1. 📊 Health Metrics Tracking

* Add key health data:

  * Blood Pressure
  * Blood Sugar
  * Weight
* Store:

  * Value
  * Date
  * Notes
* Display:

  * Trend charts
  * Normal range reference lines
  * Status indicators (normal / warning)

---

### 2. 📄 Medical Reports Upload

* Upload report images (JPG/PNG)
* Features:

  * Image preview
  * Categorization (e.g. Blood Test, Scan)
  * Upload date tracking

---

### 3. 📅 Appointment Reminders

* Create appointments:

  * Title
  * Date & time
* UI features:

  * Large, readable text (elderly-friendly)
  * Countdown to next appointment
  * Visual urgency indicators

---

### 4. 💊 Medication Tracking (Simple)

* Track medication list:

  * Name
  * Dosage
  * Frequency
* Daily checklist (basic)

---

### 5. 🍽️ Daily Wellness (Simple Version)

* Static or semi-random:

  * Meal suggestions
  * Light exercise reminders

---

## 🤖 Optional MVP+ Feature (If Time Allows)

### AI Chat Assistant (Basic)

* Input via text:

  * “Blood pressure 140 over 90 today”

* AI extracts structured data:

  * Saves as health record

* Simple chat support:

  * “What should I monitor for diabetes?”
  * “Remind me what this report means” (basic)

---

# 🎨 Design System

**Theme:**

* 🌿 Sage Green + Warm Cream
* Soft, calming, non-clinical

**Typography:**

* Large, readable fonts (Quicksand / Nunito)
* Optimized for elderly users

**UI Principles:**

* Rounded cards
* Big buttons
* High contrast
* Minimal clutter

**UX Focus:**

* One action per screen
* Clear navigation
* Gentle animations (Framer Motion)

---

# 🏗️ Tech Stack

## Frontend

* React + Vite
* TypeScript
* Tailwind CSS
* Framer Motion (animations)
* Chart library (e.g., Recharts)

## Backend (Planned / Optional in MVP)

* ASP.NET Core Web API (.NET)
* Entity Framework Core
* SQLite / SQL Server

## Storage

* MVP: Local storage or simple API
* Future: Cloud storage (e.g. Azure Blob)

## AI Integration (Optional)

* OpenAI API (text parsing + chat)

---

# 📦 Project Structure (Frontend)

```
src/
 ├── components/
 ├── pages/
 │    ├── Dashboard
 │    ├── HealthRecords
 │    ├── Reports
 │    ├── Appointments
 │    └── Wellness
 ├── services/
 ├── hooks/
 ├── utils/
 └── assets/
```

---

# 📅 1-Month Development Plan

## Week 1

* Project setup (React + design system)
* Build UI scaffolding (already generated ✅)
* Create basic pages

---

## Week 2

* Health records (CRUD)
* Charts for trends
* Local state or mock backend

---

## Week 3

* Reports upload
* Appointments system
* Medication tracking

---

## Week 4

* Polish UI (accessibility focus)
* Add AI input (if time)
* Testing & bug fixes

---

# ⚠️ Out of Scope (Future Versions)

* Hospital API integration
* Advanced AI diagnosis
* Real-time notifications (push/SMS)
* Multi-user family accounts
* Smart recommendations engine

---

# 💡 Design Philosophy

This app is not just a tool — it’s a **care companion**.

It should feel:

* Calm, not overwhelming
* Supportive, not technical
* Simple, not feature-heavy

---

# 🧪 Future Enhancements

* Voice input for elderly users 🎙️
* AI health insights 📈
* Smart reminders 🔔
* Family sharing 👨‍👩‍👧‍👦
* Wearable integration ⌚

---

# ❤️ Why This Project

Managing chronic disease is not just medical — it's emotional and daily.

This project is built to:

* Reduce stress for caregivers
* Improve visibility of health trends
* Help families feel more in control

---

# 🚀 Getting Started

```bash
npm install
npm run dev
```

---

# 👨‍💻 Author

Built with care for family ❤️
