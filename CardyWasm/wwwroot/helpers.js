function downloadTemplate(fileName, contentType, content) {
    const blob = new Blob([content], { type: contentType });
    const url = URL.createObjectURL(blob);
    const anchor = document.createElement('a');
    anchor.href = url;
    anchor.download = fileName;
    anchor.click();
    URL.revokeObjectURL(url);
}

function drawOnCanvas(canvasId, rectangleColor, textToDraw) {
    const canvas = document.getElementById(canvasId);
    const ctx = canvas.getContext("2d");

    // Clear the canvas
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Draw a rectangle with the specified color
    ctx.fillStyle = rectangleColor;
    ctx.fillRect(50, 50, 200, 100);

    // Draw the specified text
    ctx.font = "20px Arial";
    ctx.fillStyle = "white";
    ctx.fillText(textToDraw, 70, 110);
}