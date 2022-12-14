export async function getImageUrl(imageBytes) {
    const blob = new Blob([imageBytes.buffer]);

    return URL.createObjectURL(blob);
}