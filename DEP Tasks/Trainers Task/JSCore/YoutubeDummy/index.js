//AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo

const searchBox = document.getElementById('searchInput');
const displayResults = document.getElementById('displayResults');
const maxResults = 15;

let previousPageToken = '';
let nextPageToken = '';

//For activating the search event on enter button
searchBox.addEventListener("keyup", function(event) {
  if (event.keyCode === 13) {
    event.preventDefault();
    document.getElementById("searchButton").click();
  }
});

function searchButtonSubmit(urls) {
    let url = '';
    if (urls === undefined) {
        url = `https://www.googleapis.com/youtube/v3/search?key=AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo&type=video&part=snippet&&maxResults=${maxResults}&q=${searchBox.value}`;
    }
    else {
        url = urls;
    }
    fetch(url, {
        mode: 'cors',
        headers: {
            'Access-Control-Allow-Origin': '*'
        }
    })
        .then(response => response.json())
        .then(data => {
            console.log(data);
            displayData(data);
        });
}

function previousResultSet() {
    let prevUrl = `https://www.googleapis.com/youtube/v3/search?key=AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo&type=video&part=snippet&&maxResults=${maxResults}&q=${searchBox.value}&pageToken=${previousPageToken}`;
    searchButtonSubmit(prevUrl);
}

function nextResultSet() {
    let nextUrl = `https://www.googleapis.com/youtube/v3/search?key=AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo&type=video&part=snippet&&maxResults=${maxResults}&q=${searchBox.value}&pageToken=${nextPageToken}`;
    searchButtonSubmit(nextUrl);
}

function displayData(data) {
    let count = 1;
    nextPageToken = data.nextPageToken;
    previousPageToken = data.prevPageToken;

    let child = displayResults.lastElementChild;
    while (child) {
        displayResults.removeChild(child);
        child = displayResults.lastElementChild;
    }

    data.items.forEach(element => {
        let cardDiv = document.createElement("div");
        cardDiv.setAttribute("class", "cardDiv");

        let thumbImage = document.createElement("img");
        thumbImage.setAttribute("id", "image");
        thumbImage.setAttribute("src", element.snippet.thumbnails.medium.url);

        let title = document.createElement("a");
        title.setAttribute("id", `title-${count}`);
        title.setAttribute("href", `https://www.youtube.com/watch?v=${element.id.videoId}`);
        title.setAttribute("style", "text-decoration:none; color:black; margin-top:10px; font-weight:600;");

        let channelName = document.createElement("p");
        channelName.setAttribute("id", `channel-${count}`);
        channelName.setAttribute("style", "color: black; margin-top: 5px; font-weight: 600; font-size: 14px");

        cardDiv.append(thumbImage);
        cardDiv.append(title);
        cardDiv.append(channelName);
        displayResults.append(cardDiv);

        document.getElementById(`title-${count}`).innerHTML = element.snippet.title;
        document.getElementById(`channel-${count}`).innerHTML = `${element.snippet.channelTitle}<i class="fas fa-check-circle"></i>`;

        count++;
    });

}