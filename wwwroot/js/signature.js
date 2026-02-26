let canvas, ctx, drawing = false;

window.initSignaturePad = function () {
    canvas = document.getElementById('signatureCanvas');
    if (!canvas) return;
    ctx = canvas.getContext('2d');
    ctx.lineWidth = 2;
    ctx.lineCap = 'round';
    ctx.strokeStyle = '#000';

    canvas.addEventListener('mousedown', e => { drawing = true; ctx.beginPath(); ctx.moveTo(e.offsetX, e.offsetY); });
    canvas.addEventListener('mousemove', e => { if (drawing) { ctx.lineTo(e.offsetX, e.offsetY); ctx.stroke(); } });
    canvas.addEventListener('mouseup', () => drawing = false);
    canvas.addEventListener('mouseleave', () => drawing = false);

    // Touch support
    canvas.addEventListener('touchstart', e => {
        e.preventDefault(); drawing = true;
        const t = e.touches[0]; const r = canvas.getBoundingClientRect();
        ctx.beginPath(); ctx.moveTo(t.clientX - r.left, t.clientY - r.top);
    });
    canvas.addEventListener('touchmove', e => {
        e.preventDefault(); if (!drawing) return;
        const t = e.touches[0]; const r = canvas.getBoundingClientRect();
        ctx.lineTo(t.clientX - r.left, t.clientY - r.top); ctx.stroke();
    });
    canvas.addEventListener('touchend', () => drawing = false);
};

window.clearSignature = function () {
    if (ctx && canvas) ctx.clearRect(0, 0, canvas.width, canvas.height);
};

window.getSignatureData = function () {
    return canvas ? canvas.toDataURL('image/png') : '';
};