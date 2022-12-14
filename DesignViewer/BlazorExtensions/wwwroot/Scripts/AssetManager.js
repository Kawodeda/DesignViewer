export async function getImageUrl(imageStream) {
    const arrayBuffer = await imageStream.arrayBuffer();
    const blob = new Blob([arrayBuffer]);

    return URL.createObjectURL(blob);
}