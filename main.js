/* ========================================
Personal Learning Platform - Main JS
======================================== */
 
// Skill data
const skills = [
{ name: 'Python', icon: 'fab fa-python' },
{ name: '数据分析', icon: 'fas fa-chart-line' },
{ name: 'SQL', icon: 'fas fa-database' },
{ name: '数据可视化', icon: 'fas fa-chart-bar' },
{ name: '数据采集', icon: 'fas fa-cloud-download-alt' },
{ name: '数据清洗', icon: 'fas fa-filter' },
{ name: '统计学', icon: 'fas fa-square-root-alt' },
{ name: 'Excel', icon: 'fas fa-file-excel' },
{ name: '机器学习', icon: 'fas fa-brain' },
{ name: '供应链分析', icon: 'fas fa-truck' },
{ name: '商业智能', icon: 'fas fa-lightbulb' },
{ name: '项目管理', icon: 'fas fa-tasks' },
{ name: 'Tableau', icon: 'fas fa-chart-pie' },
{ name: 'Power BI', icon: 'fas fa-chart-area' },
{ name: 'Git', icon: 'fab fa-git-alt' }
];
 
// ============================================
// DOM Elements
// ============================================
const navbar = document.querySelector('.navbar');
const navToggle = document.getElementById('navToggle');
const navMenu = document.querySelector('.nav-menu');
const navLinks = document.querySelectorAll('.nav-link');
const courseGrid = document.getElementById('courseGrid');
const skillsContainer = document.getElementById('skillsContainer');
const modal = document.getElementById('courseModal');
const modalOverlay = document.getElementById('modalOverlay');
const modalClose = document.getElementById('modalClose');
const modalHeader = document.getElementById('modalHeader');
const modalBody = document.getElementById('modalBody');
const chapterPanel = document.getElementById('chapterPanel');
const chapterClose = document.getElementById('chapterClose');
const chapterDetail = document.getElementById('chapterDetail');
 
let currentCourse = null;
 
// ============================================
// Navigation
// ============================================
window.addEventListener('scroll', () => {
if (window.scrollY > 50) {
navbar.classList.add('scrolled');
} else {
navbar.classList.remove('scrolled');
}
updateActiveNavLink();
checkReveal();
});
 
navToggle.addEventListener('click', () => {
navToggle.classList.toggle('active');
navMenu.classList.toggle('active');
});
 
navLinks.forEach(link => {
link.addEventListener('click', () => {
navToggle.classList.remove('active');
navMenu.classList.remove('active');
});
});
 
function updateActiveNavLink() {
const sections = document.querySelectorAll('section[id]');
const scrollPos = window.scrollY + 150;
 
sections.forEach(section => {
const top = section.offsetTop;
const height = section.offsetHeight;
const id = section.getAttribute('id');
const link = document.querySelector(`.nav-link[href="#${id}"]`);
 
if (link) {
if (scrollPos >= top && scrollPos < top + height) {
navLinks.forEach(l => l.classList.remove('active'));
link.classList.add('active');
}
}
});
}
 
// ============================================
// Render Skills
// ============================================
function renderSkills() {
skillsContainer.innerHTML = skills.map(skill => `
<span class="skill-tag">
<i class="${skill.icon}"></i>
<span>${skill.name}</span>
</span>
`).join('');
}
 
// ============================================
// Render Courses
// ============================================
function renderCourses() {
courseGrid.innerHTML = courses.map((course, index) => `
<div class="course-card reveal" style="transition-delay: ${index * 0.1}s" data-course-id="${course.id}">
<div class="course-icon" style="background: ${course.color}20; color: ${course.color}">
<i class="${course.icon}"></i>
</div>
<h3>${course.name}</h3>
<p class="course-desc">${course.desc}</p>
<div class="course-meta">
<div class="chapter-count">
<i class="fas fa-book-open"></i>
<span>${course.chapters.length} 个章节</span>
</div>
<div class="course-arrow">
<i class="fas fa-arrow-right"></i>
</div>
</div>
</div>
`).join('');
 
document.querySelectorAll('.course-card').forEach(card => {
card.addEventListener('click', () => {
const courseId = parseInt(card.dataset.courseId);
openCourseModal(courseId);
});
});
}
 
// ============================================
// Open Course Modal
// ============================================
function openCourseModal(courseId) {
const course = courses.find(c => c.id === courseId);
if (!course) return;
 
currentCourse = course;
 
modalHeader.style.background = course.color;
modalHeader.innerHTML = `
<h2>${course.name}</h2>
<p class="course-desc-full">${course.desc}</p>
<div class="course-info-row">
<span class="info-badge"><i class="fas fa-book-open"></i> ${course.chapters.length} 章节</span>
<span class="info-badge"><i class="fas fa-graduation-cap"></i> 完整课程</span>
<span class="info-badge"><i class="fas fa-code"></i> 实战练习</span>
</div>
`;
 
modalBody.innerHTML = `
<h3 class="chapters-title"><i class="fas fa-list-ol"></i> 课程章节</h3>
<div class="chapter-list">
${course.chapters.map((chapter, idx) => `
<div class="chapter-item" data-chapter-id="${chapter.id}">
<div class="chapter-number" style="background: ${course.color}">${idx + 1}</div>
<div class="chapter-info">
<h4>${chapter.title}</h4>
<p>${chapter.content.substring(0, 60)}...</p>
</div>
<div class="chapter-open"><i class="fas fa-chevron-right"></i></div>
</div>
`).join('')}
</div>
`;
 
document.querySelectorAll('.chapter-item').forEach(item => {
item.addEventListener('click', () => {
const chapterId = parseInt(item.dataset.chapterId);
openChapterPanel(chapterId);
});
});
 
modal.classList.add('active');
document.body.style.overflow = 'hidden';
}
 
// ============================================
// Open Chapter Panel
// ============================================
function openChapterPanel(chapterId) {
const chapter = currentCourse.chapters.find(c => c.id === chapterId);
if (!chapter) return;
 
const chapterIndex = currentCourse.chapters.findIndex(c => c.id === chapterId);
 
chapterDetail.innerHTML = `
<div class="chapter-detail-header" style="background: ${currentCourse.color}15">
<span class="back-btn" id="backToCourse"><i class="fas fa-arrow-left"></i> 返回章节列表</span>
<h2>第 ${chapterIndex + 1} 章：${chapter.title}</h2>
<p class="chapter-subtitle">${currentCourse.name} · 核心知识与实战练习</p>
</div>
<div class="chapter-detail-body">
<div class="detail-section">
<h3><i class="fas fa-book"></i> 章节内容</h3>
<p>${formatContent(chapter.content)}</p>
</div>
 
${chapter.knowledge && chapter.knowledge.length > 0 ? `
<div class="detail-section">
<h3><i class="fas fa-lightbulb"></i> 核心知识点</h3>
<ul class="knowledge-list">
${chapter.knowledge.map(k => `<li><span>${k}</span></li>`).join('')}
</ul>
</div>
` : ''}
 
${chapter.code ? `
<div class="detail-section">
<h3><i class="fas fa-code"></i> 代码示例</h3>
<div class="code-block">
<div class="code-block-header">
<span>Python</span>
<button class="copy-btn" onclick="copyCode(this)"><i class="fas fa-copy"></i> 复制</button>
</div>
<pre><code>${highlightCode(chapter.code)}</code></pre>
</div>
</div>
` : ''}
 
${chapter.practice && chapter.practice.length > 0 ? `
<div class="detail-section">
<h3><i class="fas fa-pencil-alt"></i> 练习题</h3>
${chapter.practice.map((p, idx) => `
<div class="practice-item">
<h4><i class="fas fa-question-circle"></i> 练习 ${idx + 1}</h4>
<p>${p}</p>
<span class="practice-hint"><i class="fas fa-lightbulb"></i> 动手实践，加深理解</span>
</div>
`).join('')}
</div>
` : ''}
</div>
`;
 
document.getElementById('backToCourse').addEventListener('click', () => {
chapterPanel.classList.remove('active');
setTimeout(() => {
document.body.style.overflow = 'hidden';
}, 100);
});
 
chapterPanel.classList.add('active');
document.body.style.overflow = 'hidden';
}
 
// ============================================
// Helper Functions
// ============================================
function formatContent(text) {
return text.split('\n').filter(line => line.trim()).map(line =>
line.trim()
).join('</p><p style="margin-bottom: 1rem;">');
}
 
function highlightCode(code) {
const keywords = ['def', 'import', 'from', 'return', 'if', 'else', 'elif', 'for', 'while', 'in', 'as', 'class', 'True', 'False', 'None', 'print', 'and', 'or', 'not', 'with', 'try', 'except', 'lambda', 'pass', 'break', 'continue'];
const functions = ['range', 'len', 'str', 'int', 'float', 'list', 'dict', 'set', 'tuple', 'open', 'input', 'type', 'isinstance', 'sum', 'max', 'min', 'abs', 'round', 'sorted', 'reversed', 'enumerate', 'zip', 'map', 'filter'];
 
let result = code;
result = result.replace(/#[^\n]*/g, match => `<span class="code-comment">${match}</span>`);
result = result.replace(/"[^"]*"|'[^']*'/g, match => `<span class="code-string">${match}</span>`);
result = result.replace(/\b\d+\.?\d*\b/g, match => `<span class="code-number">${match}</span>`);
 
keywords.forEach(kw => {
const regex = new RegExp(`\\b${kw}\\b`, 'g');
result = result.replace(regex, `<span class="code-keyword">${kw}</span>`);
});
 
functions.forEach(fn => {
const regex = new RegExp(`\\b${fn}(?=\\()`, 'g');
result = result.replace(regex, `<span class="code-func">${fn}</span>`);
});
 
return result;
}
 
function copyCode(btn) {
const codeBlock = btn.closest('.code-block').querySelector('code');
const text = codeBlock.innerText;
navigator.clipboard.writeText(text).then(() => {
const original = btn.innerHTML;
btn.innerHTML = '<i class="fas fa-check"></i> 已复制';
btn.style.background = 'var(--color-primary)';
btn.style.color = 'var(--color-white)';
setTimeout(() => {
btn.innerHTML = original;
btn.style.background = '';
btn.style.color = '';
}, 2000);
});
}
 
// Make copyCode available globally
window.copyCode = copyCode;
 
// ============================================
// Close Modals
// ============================================
modalClose.addEventListener('click', closeModal);
modalOverlay.addEventListener('click', closeModal);
 
function closeModal() {
modal.classList.remove('active');
if (!chapterPanel.classList.contains('active')) {
document.body.style.overflow = '';
}
}
 
chapterClose.addEventListener('click', () => {
chapterPanel.classList.remove('active');
if (!modal.classList.contains('active')) {
document.body.style.overflow = '';
}
});
 
document.addEventListener('keydown', (e) => {
if (e.key === 'Escape') {
if (chapterPanel.classList.contains('active')) {
chapterPanel.classList.remove('active');
}
if (modal.classList.contains('active')) {
modal.classList.remove('active');
}
document.body.style.overflow = '';
}
});
 
// ============================================
// Scroll Reveal Animation
// ============================================
function checkReveal() {
const revealElements = document.querySelectorAll('.reveal');
revealElements.forEach(el => {
const top = el.getBoundingClientRect().top;
const windowHeight = window.innerHeight;
if (top < windowHeight - 100) {
el.classList.add('visible');
}
});
}
 
// ============================================
// Counter Animation
// ============================================
function animateCounters() {
const counters = document.querySelectorAll('.stat-value');
counters.forEach(counter => {
const target = parseInt(counter.dataset.count);
const duration = 2000;
const step = target / (duration / 16);
let current = 0;
 
const updateCounter = () => {
current += step;
if (current < target) {
counter.textContent = Math.floor(current) + '+';
requestAnimationFrame(updateCounter);
} else {
counter.textContent = target + '+';
}
};
 
const observer = new IntersectionObserver((entries) => {
entries.forEach(entry => {
if (entry.isIntersecting) {
updateCounter();
observer.unobserve(entry.target);
}
});
});
observer.observe(counter);
});
}
 
// ============================================
// Initialize
// ============================================
document.addEventListener('DOMContentLoaded', () => {
renderSkills();
renderCourses();
animateCounters();
checkReveal();
updateActiveNavLink();
});
