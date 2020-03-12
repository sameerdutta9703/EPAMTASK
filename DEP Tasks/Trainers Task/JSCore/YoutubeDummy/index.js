//AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo

var searchBox = document.getElementById('searchInput');
var displayResults = document.getElementById('displayResults');
var maxResults = 15;

var previousPageToken = '';
var nextPageToken = '';


function searchButtonSubmit(urls) {
    var url = '';
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
    var prevUrl = `https://www.googleapis.com/youtube/v3/search?key=AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo&type=video&part=snippet&&maxResults=${maxResults}&q=${searchBox.value}&pageToken=${previousPageToken}`;
    searchButtonSubmit(prevUrl);
}

function nextResultSet() {
    var nextUrl = `https://www.googleapis.com/youtube/v3/search?key=AIzaSyAkNkBT_H-jfF3J8jIB083yonYXrQKMUBo&type=video&part=snippet&&maxResults=${maxResults}&q=${searchBox.value}&pageToken=${nextPageToken}`;
    searchButtonSubmit(nextUrl);
}

function displayData(data) {
    let count = 1;
    nextPageToken = data.nextPageToken;
    previousPageToken = data.prevPageToken;

    var child = displayResults.lastElementChild;
    while (child) {
        displayResults.removeChild(child);
        child = displayResults.lastElementChild;
    }

    data.items.forEach(element => {
        var cardDiv = document.createElement("div");
        cardDiv.setAttribute("class", "cardDiv");

        var thumbImage = document.createElement("img");
        thumbImage.setAttribute("id", "image");
        thumbImage.setAttribute("src", element.snippet.thumbnails.medium.url);

        var title = document.createElement("a");
        title.setAttribute("id", `title-${count}`);
        title.setAttribute("href", `https://www.youtube.com/watch?v=${element.id.videoId}`);
        title.setAttribute("style", "text-decoration:none; color:black; margin-top:10px; font-weight:600;");

        var channelName = document.createElement("p");
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