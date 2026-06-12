/* ================================
Global Reset & Variables
================================ */
* {
margin: 0;
padding: 0;
box-sizing: border-box;
}
 
:root {
--color-primary: #6366f1;
--color-primary-dark: #4f46e5;
--color-accent: #8b5cf6;
--color-secondary: #ec4899;
--color-dark: #0f172a;
--color-gray-900: #1e293b;
--color-gray-800: #334155;
--color-gray-700: #475569;
--color-gray-600: #64748b;
--color-gray-500: #94a3b8;
--color-gray-400: #cbd5e1;
--color-gray-300: #e2e8f0;
--color-gray-200: #f1f5f9;
--color-gray-100: #f8fafc;
--color-white: #ffffff;
--gradient-primary: linear-gradient(135deg, #6366f1 0%, #8b5cf6 50%, #ec4899 100%);
--gradient-dark: linear-gradient(135deg, #1e293b 0%, #0f172a 100%);
--gradient-card: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(255,255,255,0.85) 100%);
--shadow-sm: 0 2px 8px rgba(0, 0, 0, 0.06);
--shadow-md: 0 8px 24px rgba(0, 0, 0, 0.08);
--shadow-lg: 0 20px 60px rgba(0, 0, 0, 0.12);
--shadow-glow: 0 0 40px rgba(99, 102, 241, 0.3);
--radius-sm: 8px;
--radius-md: 16px;
--radius-lg: 24px;
--radius-full: 9999px;
--transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
--transition-slow: all 0.6s cubic-bezier(0.4, 0, 0.2, 1);
--font-sans: 'PingFang SC', 'Microsoft YaHei', system-ui, -apple-system, sans-serif;
}
 
html {
scroll-behavior: smooth;
font-size: 16px;
}
 
body {
font-family: var(--font-sans);
color: var(--color-dark);
background: var(--color-gray-100);
line-height: 1.6;
overflow-x: hidden;
-webkit-font-smoothing: antialiased;
-moz-osx-font-smoothing: grayscale;
}
 
.container {
max-width: 1280px;
margin: 0 auto;
padding: 0 2rem;
}
 
a {
color: inherit;
text-decoration: none;
transition: var(--transition);
}
 
/* ================================
Navigation
================================ */
.navbar {
position: fixed;
top: 0;
left: 0;
right: 0;
z-index: 1000;
background: rgba(255, 255, 255, 0.85);
backdrop-filter: blur(20px);
-webkit-backdrop-filter: blur(20px);
border-bottom: 1px solid rgba(99, 102, 241, 0.1);
transition: var(--transition);
}
 
.navbar.scrolled {
background: rgba(255, 255, 255, 0.95);
box-shadow: var(--shadow-sm);
}
 
.nav-container {
max-width: 1280px;
margin: 0 auto;
padding: 1rem 2rem;
display: flex;
align-items: center;
justify-content: space-between;
}
 
.nav-logo {
display: flex;
flex-direction: column;
line-height: 1.2;
}
 
.logo-text {
font-size: 1.5rem;
font-weight: 700;
background: var(--gradient-primary);
-webkit-background-clip: text;
-webkit-text-fill-color: transparent;
background-clip: text;
}
 
.logo-sub {
font-size: 0.75rem;
color: var(--color-gray-500);
letter-spacing: 2px;
}
 
.nav-menu {
display: flex;
list-style: none;
gap: 2rem;
}
 
.nav-link {
position: relative;
font-size: 0.95rem;
font-weight: 500;
color: var(--color-gray-700);
padding: 0.5rem 0;
transition: var(--transition);
}
 
.nav-link::after {
content: '';
position: absolute;
bottom: 0;
left: 50%;
width: 0;
height: 2px;
background: var(--gradient-primary);
transition: var(--transition);
transform: translateX(-50%);
}
 
.nav-link:hover,
.nav-link.active {
color: var(--color-primary);
}
 
.nav-link:hover::after,
.nav-link.active::after {
width: 100%;
}
 
.nav-toggle {
display: none;
flex-direction: column;
gap: 4px;
background: none;
border: none;
cursor: pointer;
padding: 8px;
}
 
.nav-toggle span {
width: 24px;
height: 2px;
background: var(--color-dark);
border-radius: 2px;
transition: var(--transition);
}
 
.nav-toggle.active span:nth-child(1) {
transform: rotate(45deg) translate(5px, 5px);
}
 
.nav-toggle.active span:nth-child(2) {
opacity: 0;
}
 
.nav-toggle.active span:nth-child(3) {
transform: rotate(-45deg) translate(7px, -7px);
}
 
/* ================================
Hero Section
================================ */
.hero {
position: relative;
min-height: 100vh;
display: flex;
align-items: center;
padding: 8rem 2rem 4rem;
overflow: hidden;
background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 50%, #f1f5f9 100%);
}
 
.hero-bg {
position: absolute;
inset: 0;
overflow: hidden;
z-index: 0;
}
 
.gradient-circle {
position: absolute;
border-radius: 50%;
filter: blur(80px);
opacity: 0.5;
animation: float 20s ease-in-out infinite;
}
 
.circle-1 {
width: 500px;
height: 500px;
background: radial-gradient(circle, #6366f1, transparent);
top: -10%;
left: -10%;
}
 
.circle-2 {
width: 400px;
height: 400px;
background: radial-gradient(circle, #ec4899, transparent);
bottom: -10%;
right: -5%;
animation-delay: -5s;
}
 
.circle-3 {
width: 350px;
height: 350px;
background: radial-gradient(circle, #8b5cf6, transparent);
top: 40%;
right: 20%;
animation-delay: -10s;
}
 
@keyframes float {
0%, 100% { transform: translate(0, 0) scale(1); }
33% { transform: translate(30px, -30px) scale(1.1); }
66% { transform: translate(-20px, 20px) scale(0.95); }
}
 
.hero-content {
position: relative;
z-index: 1;
max-width: 1280px;
margin: 0 auto;
display: grid;
grid-template-columns: 1fr 1fr;
gap: 4rem;
align-items: center;
width: 100%;
}
 
.hero-text {
animation: fadeInUp 0.8s ease-out;
}
 
.hero-badge {
display: inline-flex;
align-items: center;
gap: 0.75rem;
padding: 0.5rem 1.25rem;
background: rgba(99, 102, 241, 0.1);
border: 1px solid rgba(99, 102, 241, 0.2);
border-radius: var(--radius-full);
font-size: 0.875rem;
color: var(--color-primary);
margin-bottom: 1.5rem;
}
 
.badge-dot {
width: 8px;
height: 8px;
background: var(--color-primary);
border-radius: 50%;
animation: pulse 2s ease-in-out infinite;
}
 
@keyframes pulse {
0%, 100% { opacity: 1; transform: scale(1); }
50% { opacity: 0.5; transform: scale(1.3); }
}
 
.hero-title {
font-size: clamp(2.5rem, 5vw, 4rem);
font-weight: 800;
line-height: 1.1;
margin-bottom: 1.5rem;
}
 
.title-line {
display: block;
font-size: 1.5rem;
font-weight: 500;
color: var(--color-gray-600);
margin-bottom: 0.5rem;
}
 
.title-name {
display: block;
color: var(--color-dark);
letter-spacing: -2px;
}
 
.title-gradient {
display: block;
background: var(--gradient-primary);
-webkit-background-clip: text;
-webkit-text-fill-color: transparent;
background-clip: text;
font-size: clamp(1.8rem, 3.5vw, 3rem);
margin-top: 0.25rem;
}
 
.hero-description {
font-size: 1.125rem;
color: var(--color-gray-600);
margin-bottom: 2.5rem;
max-width: 540px;
line-height: 1.8;
}
 
.hero-stats {
display: flex;
gap: 2.5rem;
margin-bottom: 2.5rem;
}
 
.stat-item {
display: flex;
flex-direction: column;
}
 
.stat-value {
font-size: 2.25rem;
font-weight: 800;
background: var(--gradient-primary);
-webkit-background-clip: text;
-webkit-text-fill-color: transparent;
background-clip: text;
line-height: 1;
}
 
.stat-label {
font-size: 0.875rem;
color: var(--color-gray-500);
margin-top: 0.25rem;
}
 
.hero-actions {
display: flex;
gap: 1rem;
flex-wrap: wrap;
}
 
.btn {
display: inline-flex;
align-items: center;
justify-content: center;
gap: 0.5rem;
padding: 1rem 2rem;
font-size: 1rem;
font-weight: 600;
border-radius: var(--radius-full);
border: none;
cursor: pointer;
transition: var(--transition);
position: relative;
overflow: hidden;
}
 
.btn-primary {
background: var(--gradient-primary);
color: var(--color-white);
box-shadow: 0 8px 24px rgba(99, 102, 241, 0.4);
}
 
.btn-primary:hover {
transform: translateY(-2px);
box-shadow: 0 12px 32px rgba(99, 102, 241, 0.5);
}
 
.btn-primary i {
transition: var(--transition);
}
 
.btn-primary:hover i {
transform: translateX(4px);
}
 
.btn-secondary {
background: rgba(255, 255, 255, 0.8);
color: var(--color-dark);
border: 2px solid var(--color-gray-300);
backdrop-filter: blur(10px);
}
 
.btn-secondary:hover {
border-color: var(--color-primary);
color: var(--color-primary);
transform: translateY(-2px);
}
 
/* Hero Visual */
.hero-visual {
position: relative;
display: flex;
justify-content: center;
align-items: center;
min-height: 500px;
}
 
.avatar-container {
position: relative;
width: 380px;
height: 380px;
animation: fadeInRight 1s ease-out 0.3s both;
}
 
.avatar-ring {
position: absolute;
inset: 0;
border-radius: 50%;
border: 3px solid transparent;
background: conic-gradient(from 0deg, #6366f1, #8b5cf6, #ec4899, #6366f1);
-webkit-mask: linear-gradient(#fff 0 0) content-box, linear-gradient(#fff 0 0);
mask: linear-gradient(#fff 0 0) content-box, linear-gradient(#fff 0 0);
-webkit-mask-composite: xor;
mask-composite: exclude;
padding: 8px;
animation: spin 15s linear infinite;
}
 
.avatar-ring-2 {
position: absolute;
inset: 20px;
border-radius: 50%;
border: 2px dashed rgba(99, 102, 241, 0.3);
animation: spin 30s linear infinite reverse;
}
 
@keyframes spin {
from { transform: rotate(0deg); }
to { transform: rotate(360deg); }
}
 
.avatar-main {
position: absolute;
inset: 40px;
border-radius: 50%;
background: var(--gradient-primary);
display: flex;
align-items: center;
justify-content: center;
font-size: 8rem;
color: var(--color-white);
box-shadow: var(--shadow-lg), var(--shadow-glow);
}
 
.floating-card {
position: absolute;
display: flex;
align-items: center;
gap: 0.75rem;
padding: 1rem 1.5rem;
background: rgba(255, 255, 255, 0.95);
backdrop-filter: blur(10px);
border-radius: var(--radius-md);
box-shadow: var(--shadow-md);
font-weight: 600;
font-size: 0.9rem;
animation: floatCard 6s ease-in-out infinite;
}
 
.floating-card i {
font-size: 1.25rem;
}
 
.card-1 {
top: 10%;
left: -10%;
color: var(--color-primary);
}
 
.card-1 i {
color: var(--color-primary);
}
 
.card-2 {
bottom: 20%;
left: -5%;
color: var(--color-accent);
animation-delay: -2s;
}
 
.card-2 i {
color: var(--color-accent);
}
 
.card-3 {
top: 30%;
right: -10%;
color: var(--color-secondary);
animation-delay: -4s;
}
 
.card-3 i {
color: var(--color-secondary);
}
 
@keyframes floatCard {
0%, 100% { transform: translateY(0); }
50% { transform: translateY(-15px); }
}
 
@keyframes fadeInUp {
from {
opacity: 0;
transform: translateY(30px);
}
to {
opacity: 1;
transform: translateY(0);
}
}
 
@keyframes fadeInRight {
from {
opacity: 0;
transform: translateX(50px);
}
to {
opacity: 1;
transform: translateX(0);
}
}
 
.scroll-hint {
position: absolute;
bottom: 2rem;
left: 50%;
transform: translateX(-50%);
display: flex;
flex-direction: column;
align-items: center;
gap: 0.5rem;
color: var(--color-gray-500);
font-size: 0.875rem;
animation: bounce 2s ease-in-out infinite;
}
 
.scroll-arrow {
width: 36px;
height: 36px;
border-radius: 50%;
background: rgba(255, 255, 255, 0.8);
display: flex;
align-items: center;
justify-content: center;
box-shadow: var(--shadow-sm);
}
 
@keyframes bounce {
0%, 100% { transform: translate(-50%, 0); }
50% { transform: translate(-50%, 10px); }
}
 
/* ================================
Section Headers
================================ */
section {
padding: 6rem 0;
}
 
.section-header {
text-align: center;
margin-bottom: 4rem;
}
 
.section-tag {
display: inline-block;
padding: 0.4rem 1rem;
background: rgba(99, 102, 241, 0.1);
color: var(--color-primary);
border-radius: var(--radius-full);
font-size: 0.875rem;
font-weight: 600;
letter-spacing: 1px;
margin-bottom: 1rem;
}
 
.section-title {
font-size: clamp(2rem, 4vw, 3rem);
font-weight: 800;
margin-bottom: 1rem;
background: linear-gradient(135deg, #0f172a 0%, #4f46e5 100%);
-webkit-background-clip: text;
-webkit-text-fill-color: transparent;
background-clip: text;
}
 
.section-desc {
font-size: 1.125rem;
color: var(--color-gray-600);
max-width: 600px;
margin: 0 auto;
}
 
/* ================================
About Section
================================ */
.about {
background: var(--color-white);
}
 
.about-grid {
display: grid;
grid-template-columns: repeat(auto-fit, minmax(260px, 1fr));
gap: 2rem;
}
 
.about-card {
padding: 2.5rem 2rem;
background: var(--color-gray-100);
border-radius: var(--radius-lg);
text-align: center;
transition: var(--transition);
position: relative;
overflow: hidden;
border: 1px solid transparent;
}
 
.about-card::before {
content: '';
position: absolute;
top: 0;
left: 0;
right: 0;
height: 4px;
background: var(--gradient-primary);
transform: scaleX(0);
transform-origin: left;
transition: var(--transition);
}
 
.about-card:hover {
background: var(--color-white);
border-color: var(--color-gray-200);
box-shadow: var(--shadow-lg);
transform: translateY(-8px);
}
 
.about-card:hover::before {
transform: scaleX(1);
}
 
.card-icon {
width: 72px;
height: 72px;
margin: 0 auto 1.5rem;
background: var(--gradient-primary);
border-radius: var(--radius-md);
display: flex;
align-items: center;
justify-content: center;
font-size: 2rem;
color: var(--color-white);
transition: var(--transition);
}
 
.about-card:hover .card-icon {
transform: scale(1.1) rotate(-5deg);
}
 
.about-card h3 {
font-size: 1.375rem;
font-weight: 700;
margin-bottom: 1rem;
color: var(--color-dark);
}
 
.about-card p {
color: var(--color-gray-600);
line-height: 1.8;
}
 
/* ================================
Skills Section
================================ */
.skills {
background: var(--color-gray-100);
}
 
.skills-container {
display: flex;
flex-wrap: wrap;
justify-content: center;
gap: 1rem;
max-width: 900px;
margin: 0 auto;
}
 
.skill-tag {
display: inline-flex;
align-items: center;
gap: 0.5rem;
padding: 0.875rem 1.5rem;
background: var(--color-white);
border: 1px solid var(--color-gray-200);
border-radius: var(--radius-full);
font-weight: 500;
font-size: 0.95rem;
color: var(--color-gray-700);
transition: var(--transition);
cursor: default;
}
 
.skill-tag:hover {
background: var(--gradient-primary);
color: var(--color-white);
border-color: transparent;
transform: translateY(-4px);
box-shadow: var(--shadow-md);
}
 
.skill-tag i {
color: var(--color-primary);
transition: var(--transition);
}
 
.skill-tag:hover i {
color: var(--color-white);
}
 
/* ================================
Courses Section
================================ */
.courses {
background: var(--color-white);
}
 
.course-grid {
display: grid;
grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
gap: 2rem;
}
 
.course-card {
position: relative;
padding: 2rem;
background: var(--color-white);
border-radius: var(--radius-lg);
border: 1px solid var(--color-gray-200);
cursor: pointer;
transition: var(--transition);
overflow: hidden;
}
 
.course-card::before {
content: '';
position: absolute;
top: 0;
left: 0;
right: 0;
height: 100%;
background: var(--gradient-primary);
opacity: 0;
transition: var(--transition);
z-index: 0;
}
 
.course-card:hover {
transform: translateY(-12px);
box-shadow: var(--shadow-lg);
border-color: transparent;
}
 
.course-card:hover::before {
opacity: 0.03;
}
 
.course-card > * {
position: relative;
z-index: 1;
}
 
.course-icon {
width: 64px;
height: 64px;
border-radius: var(--radius-md);
display: flex;
align-items: center;
justify-content: center;
font-size: 1.75rem;
margin-bottom: 1.5rem;
transition: var(--transition);
}
 
.course-card:hover .course-icon {
transform: scale(1.15) rotate(5deg);
}
 
.course-card h3 {
font-size: 1.375rem;
font-weight: 700;
margin-bottom: 0.75rem;
color: var(--color-dark);
transition: var(--transition);
}
 
.course-card:hover h3 {
color: var(--color-primary-dark);
}
 
.course-card .course-desc {
color: var(--color-gray-600);
margin-bottom: 1.5rem;
line-height: 1.7;
font-size: 0.95rem;
}
 
.course-meta {
display: flex;
justify-content: space-between;
align-items: center;
padding-top: 1.25rem;
border-top: 1px solid var(--color-gray-200);
transition: var(--transition);
}
 
.course-card:hover .course-meta {
border-top-color: rgba(255,255,255,0.2);
}
 
.chapter-count {
display: flex;
align-items: center;
gap: 0.5rem;
font-size: 0.9rem;
color: var(--color-gray-500);
}
 
.course-arrow {
width: 40px;
height: 40px;
border-radius: 50%;
background: var(--color-gray-100);
display: flex;
align-items: center;
justify-content: center;
color: var(--color-gray-600);
transition: var(--transition);
}
 
.course-card:hover .course-arrow {
background: var(--gradient-primary);
color: var(--color-white);
transform: translateX(4px);
}
 
/* ================================
Modal
================================ */
.modal {
position: fixed;
inset: 0;
z-index: 2000;
display: none;
align-items: center;
justify-content: center;
padding: 2rem;
}
 
.modal.active {
display: flex;
animation: fadeIn 0.3s ease-out;
}
 
.modal-overlay {
position: absolute;
inset: 0;
background: rgba(15, 23, 42, 0.7);
backdrop-filter: blur(8px);
-webkit-backdrop-filter: blur(8px);
}
 
.modal-content {
position: relative;
width: 100%;
max-width: 900px;
max-height: 85vh;
background: var(--color-white);
border-radius: var(--radius-lg);
box-shadow: var(--shadow-lg);
overflow: hidden;
display: flex;
flex-direction: column;
animation: slideUp 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}
 
@keyframes fadeIn {
from { opacity: 0; }
to { opacity: 1; }
}
 
@keyframes slideUp {
from {
opacity: 0;
transform: translateY(40px) scale(0.96);
}
to {
opacity: 1;
transform: translateY(0) scale(1);
}
}
 
.modal-close {
position: absolute;
top: 1.5rem;
right: 1.5rem;
width: 40px;
height: 40px;
border: none;
background: rgba(255, 255, 255, 0.9);
border-radius: 50%;
cursor: pointer;
font-size: 1.25rem;
color: var(--color-gray-700);
z-index: 10;
transition: var(--transition);
display: flex;
align-items: center;
justify-content: center;
}
 
.modal-close:hover {
background: var(--color-dark);
color: var(--color-white);
transform: rotate(90deg);
}
 
.modal-header {
padding: 2.5rem 2.5rem 2rem;
color: var(--color-white);
position: relative;
}
 
.modal-header h2 {
font-size: 2rem;
font-weight: 800;
margin-bottom: 0.75rem;
}
 
.modal-header .course-desc-full {
font-size: 1rem;
opacity: 0.9;
max-width: 600px;
}
 
.modal-header .course-info-row {
display: flex;
gap: 1rem;
margin-top: 1.25rem;
flex-wrap: wrap;
}
 
.info-badge {
display: inline-flex;
align-items: center;
gap: 0.5rem;
padding: 0.5rem 1rem;
background: rgba(255, 255, 255, 0.2);
border-radius: var(--radius-full);
font-size: 0.875rem;
backdrop-filter: blur(4px);
}
 
.modal-body {
flex: 1;
overflow-y: auto;
padding: 2rem 2.5rem 2.5rem;
}
 
.chapters-title {
font-size: 1.25rem;
font-weight: 700;
margin-bottom: 1.5rem;
color: var(--color-dark);
}
 
.chapter-list {
display: flex;
flex-direction: column;
gap: 1rem;
}
 
.chapter-item {
display: flex;
align-items: center;
gap: 1.25rem;
padding: 1.25rem 1.5rem;
background: var(--color-gray-100);
border-radius: var(--radius-md);
cursor: pointer;
transition: var(--transition);
border: 2px solid transparent;
}
 
.chapter-item:hover {
background: var(--color-white);
border-color: var(--color-gray-200);
box-shadow: var(--shadow-md);
transform: translateX(8px);
}
 
.chapter-number {
flex-shrink: 0;
width: 48px;
height: 48px;
border-radius: var(--radius-md);
background: var(--gradient-primary);
color: var(--color-white);
display: flex;
align-items: center;
justify-content: center;
font-weight: 700;
font-size: 1.125rem;
}
 
.chapter-info {
flex: 1;
}
 
.chapter-info h4 {
font-size: 1.125rem;
font-weight: 600;
color: var(--color-dark);
margin-bottom: 0.25rem;
}
 
.chapter-info p {
font-size: 0.9rem;
color: var(--color-gray-500);
}
 
.chapter-open {
color: var(--color-gray-400);
transition: var(--transition);
}
 
.chapter-item:hover .chapter-open {
color: var(--color-primary);
}
 
/* ================================
Chapter Panel
================================ */
.chapter-panel {
position: fixed;
inset: 0;
z-index: 3000;
display: none;
align-items: center;
justify-content: center;
padding: 2rem;
}
 
.chapter-panel.active {
display: flex;
animation: fadeIn 0.3s ease-out;
}
 
.chapter-panel::before {
content: '';
position: absolute;
inset: 0;
background: rgba(15, 23, 42, 0.75);
backdrop-filter: blur(8px);
-webkit-backdrop-filter: blur(8px);
}
 
.chapter-content {
position: relative;
width: 100%;
max-width: 800px;
max-height: 90vh;
background: var(--color-white);
border-radius: var(--radius-lg);
box-shadow: var(--shadow-lg);
overflow-y: auto;
animation: slideUp 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}
 
.chapter-close {
position: absolute;
top: 1.5rem;
right: 1.5rem;
width: 40px;
height: 40px;
border: none;
background: var(--color-gray-100);
border-radius: 50%;
cursor: pointer;
font-size: 1.125rem;
color: var(--color-gray-700);
z-index: 10;
transition: var(--transition);
display: flex;
align-items: center;
justify-content: center;
}
 
.chapter-close:hover {
background: var(--color-dark);
color: var(--color-white);
transform: rotate(90deg);
}
 
.chapter-detail-header {
padding: 2.5rem 2.5rem 1.5rem;
border-bottom: 1px solid var(--color-gray-200);
}
 
.chapter-detail-header .back-btn {
display: inline-flex;
align-items: center;
gap: 0.5rem;
color: var(--color-primary);
font-weight: 500;
font-size: 0.9rem;
margin-bottom: 1rem;
cursor: pointer;
transition: var(--transition);
}
 
.chapter-detail-header .back-btn:hover {
transform: translateX(-4px);
}
 
.chapter-detail-header h2 {
font-size: 1.75rem;
font-weight: 800;
color: var(--color-dark);
margin-bottom: 0.5rem;
}
 
.chapter-detail-header .chapter-subtitle {
color: var(--color-gray-500);
font-size: 1rem;
}
 
.chapter-detail-body {
padding: 2rem 2.5rem 2.5rem;
}
 
.detail-section {
margin-bottom: 2.5rem;
}
 
.detail-section:last-child {
margin-bottom: 0;
}
 
.detail-section h3 {
display: flex;
align-items: center;
gap: 0.75rem;
font-size: 1.25rem;
font-weight: 700;
color: var(--color-dark);
margin-bottom: 1.25rem;
padding-bottom: 0.75rem;
border-bottom: 2px solid var(--color-gray-200);
}
 
.detail-section h3 i {
width: 40px;
height: 40px;
background: var(--gradient-primary);
border-radius: var(--radius-sm);
display: flex;
align-items: center;
justify-content: center;
color: var(--color-white);
font-size: 1rem;
}
 
.detail-section p {
color: var(--color-gray-700);
line-height: 1.9;
margin-bottom: 1rem;
}
 
.knowledge-list {
list-style: none;
display: flex;
flex-direction: column;
gap: 0.875rem;
}
 
.knowledge-list li {
display: flex;
align-items: flex-start;
gap: 1rem;
padding: 1rem 1.25rem;
background: var(--color-gray-100);
border-radius: var(--radius-md);
transition: var(--transition);
}
 
.knowledge-list li:hover {
background: var(--color-white);
box-shadow: var(--shadow-sm);
transform: translateX(4px);
}
 
.knowledge-list li::before {
content: '✓';
flex-shrink: 0;
width: 24px;
height: 24px;
background: var(--color-primary);
color: var(--color-white);
border-radius: 50%;
display: flex;
align-items: center;
justify-content: center;
font-size: 0.8rem;
font-weight: 700;
}
 
.knowledge-list li span {
flex: 1;
color: var(--color-gray-700);
line-height: 1.6;
}
 
.code-block {
background: var(--color-dark);
border-radius: var(--radius-md);
overflow: hidden;
margin-bottom: 1rem;
}
 
.code-block-header {
display: flex;
align-items: center;
justify-content: space-between;
padding: 0.75rem 1rem;
background: var(--color-gray-900);
border-bottom: 1px solid var(--color-gray-800);
}
 
.code-block-header span {
color: var(--color-gray-400);
font-size: 0.85rem;
font-family: 'Courier New', monospace;
}
 
.copy-btn {
background: none;
border: 1px solid var(--color-gray-700);
color: var(--color-gray-400);
padding: 0.375rem 0.75rem;
border-radius: var(--radius-sm);
cursor: pointer;
font-size: 0.8rem;
transition: var(--transition);
}
 
.copy-btn:hover {
background: var(--color-primary);
color: var(--color-white);
border-color: var(--color-primary);
}
 
.code-block pre {
padding: 1.25rem;
margin: 0;
overflow-x: auto;
font-family: 'Courier New', monospace;
font-size: 0.9rem;
line-height: 1.7;
color: #e2e8f0;
}
 
.code-block code {
display: block;
}
 
.code-keyword {
color: #c084fc;
}
 
.code-string {
color: #86efac;
}
 
.code-number {
color: #fbbf24;
}
 
.code-comment {
color: #64748b;
font-style: italic;
}
 
.code-func {
color: #60a5fa;
}
 
.practice-item {
padding: 1.5rem;
background: linear-gradient(135deg, rgba(99, 102, 241, 0.05) 0%, rgba(139, 92, 246, 0.05) 100%);
border: 1px solid rgba(99, 102, 241, 0.15);
border-radius: var(--radius-md);
margin-bottom: 1rem;
transition: var(--transition);
}
 
.practice-item:hover {
background: linear-gradient(135deg, rgba(99, 102, 241, 0.08) 0%, rgba(139, 92, 246, 0.08) 100%);
box-shadow: var(--shadow-sm);
}
 
.practice-item h4 {
display: flex;
align-items: center;
gap: 0.5rem;
font-size: 1.05rem;
font-weight: 600;
color: var(--color-dark);
margin-bottom: 0.75rem;
}
 
.practice-item h4 i {
color: var(--color-primary);
}
 
.practice-item p {
color: var(--color-gray-600);
line-height: 1.7;
margin-bottom: 0.75rem;
}
 
.practice-hint {
display: inline-flex;
align-items: center;
gap: 0.5rem;
padding: 0.375rem 0.75rem;
background: var(--color-white);
border: 1px solid var(--color-gray-200);
border-radius: var(--radius-sm);
font-size: 0.85rem;
color: var(--color-gray-500);
}
 
/* ================================
Contact Section
================================ */
.contact {
background: var(--gradient-dark);
color: var(--color-white);
padding: 5rem 0;
}
 
.contact-wrapper {
display: grid;
grid-template-columns: 1.5fr 1fr;
gap: 4rem;
align-items: center;
}
 
.contact-info .section-tag {
background: rgba(99, 102, 241, 0.2);
color: #a5b4fc;
}
 
.contact-info h2 {
font-size: clamp(1.75rem, 3vw, 2.5rem);
font-weight: 800;
margin: 1rem 0 1rem;
line-height: 1.2;
}
 
.contact-info > p {
color: rgba(255, 255, 255, 0.7);
font-size: 1.05rem;
margin-bottom: 2rem;
max-width: 500px;
}
 
.contact-items {
display: flex;
flex-direction: column;
gap: 1.25rem;
}
 
.contact-item {
display: flex;
align-items: center;
gap: 1rem;
padding: 1rem 1.5rem;
background: rgba(255, 255, 255, 0.05);
border: 1px solid rgba(255, 255, 255, 0.1);
border-radius: var(--radius-md);
transition: var(--transition);
}
 
.contact-item:hover {
background: rgba(99, 102, 241, 0.1);
border-color: rgba(99, 102, 241, 0.3);
transform: translateX(8px);
}
 
.contact-item i {
font-size: 1.25rem;
color: #a5b4fc;
}
 
.contact-item span {
font-size: 1rem;
}
 
.contact-visual {
display: flex;
justify-content: center;
}
 
.contact-orb {
width: 280px;
height: 280px;
border-radius: 50%;
background: var(--gradient-primary);
display: flex;
align-items: center;
justify-content: center;
font-size: 7rem;
color: var(--color-white);
box-shadow: 0 0 80px rgba(99, 102, 241, 0.4);
animation: orbFloat 6s ease-in-out infinite;
}
 
@keyframes orbFloat {
0%, 100% { transform: translateY(0) scale(1); }
50% { transform: translateY(-20px) scale(1.05); }
}
 
/* ================================
Footer
================================ */
.footer {
background: var(--color-dark);
color: var(--color-gray-400);
padding: 2rem 0;
text-align: center;
}
 
.footer-content p {
font-size: 0.9rem;
margin: 0.25rem 0;
}
 
.footer-motto {
color: var(--color-gray-500);
font-style: italic;
}
 
/* ================================
Scroll Reveal Animation
================================ */
.reveal {
opacity: 0;
transform: translateY(30px);
transition: opacity 0.8s ease-out, transform 0.8s ease-out;
}
 
.reveal.visible {
opacity: 1;
transform: translateY(0);
}
 
/* ================================
Custom Scrollbar
================================ */
::-webkit-scrollbar {
width: 10px;
height: 10px;
}
 
::-webkit-scrollbar-track {
background: var(--color-gray-100);
}
 
::-webkit-scrollbar-thumb {
background: var(--color-gray-400);
border-radius: 5px;
transition: var(--transition);
}
 
::-webkit-scrollbar-thumb:hover {
background: var(--color-primary);
}
 
.modal-content::-webkit-scrollbar,
.chapter-content::-webkit-scrollbar {
width: 8px;
}
 
.modal-content::-webkit-scrollbar-thumb,
.chapter-content::-webkit-scrollbar-thumb {
background: var(--color-gray-300);
}
 
/* ================================
Responsive Design
================================ */
@media (max-width: 1024px) {
.hero-content {
grid-template-columns: 1fr;
text-align: center;
}
 
.hero-description {
margin-left: auto;
margin-right: auto;
}
 
.hero-stats,
.hero-actions {
justify-content: center;
}
 
.hero-visual {
min-height: 400px;
margin-top: 2rem;
}
 
.avatar-container {
width: 320px;
height: 320px;
}
 
.contact-wrapper {
grid-template-columns: 1fr;
text-align: center;
}
 
.contact-items {
align-items: center;
}
}
 
@media (max-width: 768px) {
.container {
padding: 0 1.25rem;
}
 
section {
padding: 4rem 0;
}
 
.nav-menu {
position: fixed;
top: 72px;
left: 0;
right: 0;
flex-direction: column;
background: var(--color-white);
padding: 2rem;
gap: 1.5rem;
box-shadow: var(--shadow-md);
transform: translateY(-100%);
opacity: 0;
pointer-events: none;
transition: var(--transition);
}
 
.nav-menu.active {
transform: translateY(0);
opacity: 1;
pointer-events: auto;
}
 
.nav-toggle {
display: flex;
}
 
.hero {
padding: 6rem 1.25rem 3rem;
min-height: auto;
}
 
.hero-title {
font-size: 2.25rem;
}
 
.title-line {
font-size: 1.125rem;
}
 
.hero-stats {
gap: 1.5rem;
}
 
.stat-value {
font-size: 1.75rem;
}
 
.avatar-container {
width: 260px;
height: 260px;
}
 
.avatar-main {
font-size: 5rem;
}
 
.floating-card {
padding: 0.75rem 1rem;
font-size: 0.8rem;
}
 
.floating-card i {
font-size: 1rem;
}
 
.card-1 {
left: 0;
}
 
.card-2 {
left: 0;
}
 
.card-3 {
right: 0;
}
 
.about-grid {
grid-template-columns: 1fr;
}
 
.course-grid {
grid-template-columns: 1fr;
}
 
.modal {
padding: 1rem;
}
 
.modal-header {
padding: 2rem 1.5rem 1.5rem;
}
 
.modal-header h2 {
font-size: 1.5rem;
}
 
.modal-body {
padding: 1.5rem;
}
 
.chapter-panel {
padding: 1rem;
}
 
.chapter-detail-header {
padding: 2rem 1.5rem 1.25rem;
}
 
.chapter-detail-body {
padding: 1.5rem;
}
 
.contact-orb {
width: 200px;
height: 200px;
font-size: 5rem;
}
 
.btn {
padding: 0.875rem 1.5rem;
font-size: 0.95rem;
}
}
 
@media (max-width: 480px) {
.hero-title {
font-size: 2rem;
}
 
.hero-stats {
gap: 1rem;
}
 
.stat-value {
font-size: 1.5rem;
}
 
.hero-actions {
flex-direction: column;
width: 100%;
}
 
.hero-actions .btn {
width: 100%;
}
 
.avatar-container {
width: 220px;
height: 220px;
}
 
.chapter-item {
padding: 1rem;
gap: 1rem;
}
 
.chapter-number {
width: 40px;
height: 40px;
font-size: 1rem;
}
}
 
/* ================================
Reduced Motion
================================ */
@media (prefers-reduced-motion: reduce) {
*,
*::before,
*::after {
animation-duration: 0.01ms !important;
animation-iteration-count: 1 !important;
transition-duration: 0.01ms !important;
}
 
html {
scroll-behavior: auto;
}
}
