window.drawChromatogram = (data) => {
  const canvas = document.getElementById("chromatogramCanvas");
  const ctx = canvas.getContext("2d");

  ctx.clearRect(0, 0, canvas.width, canvas.height);

  ctx.beginPath();
  ctx.moveTo(0, canvas.height);

  data.forEach((point) => {
    const x = point.time * (canvas.width / data[data.length - 1].time);
    const y = canvas.height - point.intensity * (canvas.height / Math.max(...data.map((p) => p.intensity)));
    ctx.lineTo(x, y);
  });

  ctx.stroke();
};
