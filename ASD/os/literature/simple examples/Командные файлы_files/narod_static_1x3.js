var y5_iR=Math.round(Math.random()*1000000);function y5_escape(B,A){if(!A){A=256}if(B==null){return""}if(B.length>A){B=B.substr(0,A)}return escape(B).replace(/\+/g,"%2B")}y5_onContent(function(){y5_checkFrames()});function y5_checkFrames(){var A=document.getElementsByTagName("FRAME");if(A.length==0){(parent.location.href!=location.href)?y5_getFrameObject():y5_getBannerData()}}function y5_getFrameObject(E){var I=parent.document.getElementsByTagName("FRAME");if(I.length>0){var D=0;var G=0;var J=I.item(0);for(var F=0;F<I.length;F++){var H=I.item(F);var B=(H.offsetWidth?H.offsetWidth:H.contentWindow.innerWidth);var A=(H.offsetHeight?H.offsetHeight:H.contentWindow.innerHeight);var C=B*A;if(C>G){D=F;G=C;J=I.item(F)}}if(parent.window.frames){if(parent.window.frames[D].document==document){y5_getBannerData()}}else{if(J.contentWindow.document==document){y5_getBannerData()}}}}function y5_getBannerData(){var A="http://bs.yandex.ru/code/"+y5_pageId+"?stat-id="+y5_statId+"&rnd="+y5_iR+"&page-ref="+y5_escape(document.referrer,512)+"&target-ref="+y5_escape(document.location.href,512);y5_addScriptCode(A)}function y5_showBanner(D){var B=document.body;var C=document.createElement("div");var A=y5_getStyleCode();y5_addStyleCode(A);C.id="y5"+y5_iR+"-banner";C.innerHTML=D;B.insertBefore(C,B.firstChild)}function yandex_direct_phonePrint(){}function y5_getStyleCode(){var B="y5"+y5_iR+"-";var C="#"+B+"banner {font-size: 11px; position: relative; z-index: 999;} #"+B+"banner * {background: none; border: 0; clip: auto; clear: both; color: #000; cursor: auto; float: none; font-family: Verdana, Arial, sans-serif; font-size: 100%; font-style: normal; font-variant: normal; font-weight: normal; line-height: 120%; margin: 0; overflow: visible; padding: 0; position: static; text-decoration: none; text-indent: 0; text-transform: none; visibility: visible; white-space: normal; word-spacing: normal;} #"+B+"banner a {cursor: pointer; cursor: hand; text-decoration: underline;} #"+B+"banner a * {cursor: pointer; cursor: hand; text-decoration: underline;} #"+B+"banner table {border-collapse: collapse;} #"+B+"banner td {color: #000; font-size: 11px; padding: 0; text-align: left; vertical-align: top;}";var E="#"+B+"banner .header {width: 100%;} #"+B+"banner .header td {width: 50%; padding: 0.25em 1em;} #"+B+"banner .header td.right {text-align: right;} #"+B+"banner .header td div {display: inline; height: 0;} #"+B+"banner .header td div * {white-space: nowrap;} #"+B+"banner .header td div.direct {margin-right: 1em;} #"+B+"banner .header td div.close {margin-left: 1em;} #"+B+"banner .header td div.close * {cursor: pointer; cursor: hand;} #"+B+"banner .header td div.close span.text {text-decoration: underline;} #"+B+"banner .data {width: 100%;} #"+B+"banner .data td.block {padding: 0.5em;} #"+B+"banner .data td.block div.ad-link {font-size: 110%; margin-bottom: 0.1em;} #"+B+"banner .data td.block span.url {display: block;}";var D="#"+B+"banner .header {background: #feeac7;} #"+B+"banner .header a {color: #000;} #"+B+"banner .data {background: #fff9f0; border: 1px solid #fbe5c0;} #"+B+"banner .data td.block div.ad-link a {color: #00c; font-weight: bold;} #"+B+"banner .data td.block span.url {color: #060;} #"+B+"banner .data td.block span.url a {color: #060;}";var F="#"+B+'banner .data td.block span.url a {background: url("http://img.yandex.net/i/ico-phone.gif") no-repeat 0 50%; padding-left: 16px;} * html #'+B+"banner .data td.block span.url a {height: 0; margin-bottom: -0.2em;}";var A=y5_addImportant(C+E+D+F);return A}function y5_getHeadObject(){var B=document.getElementsByTagName("html")[0];if(!document.getElementsByTagName("head")[0]){B.appendChild(document.createElement("head"))}var A=document.getElementsByTagName("head")[0];return A}function y5_addScriptCode(A){var B=document.createElement("script");B.src=A;B.type="text/javascript";B.charset="windows-1251";y5_getHeadObject().appendChild(B)}function y5_addStyleCode(E){var A=document.createElement("style");A.type="text/css";y5_getHeadObject().appendChild(A);var D=((navigator.userAgent.indexOf("MSIE")!=-1)&&(navigator.userAgent.indexOf("Opera")==-1));if(D){var G=E.split("}");for(var C=0;C<(G.length-1);C++){var H=G[C].substr(0,G[C].indexOf("{"));var B=G[C].substr(G[C].indexOf("{")+1,G[C].length);document.styleSheets[0].addRule(H,B)}}else{var F=document.createTextNode(E);A.appendChild(F)}}function y5_createTableData(C){var A="";for(var B=0;B<C.length;B++){A+='<td width="'+Math.round(100/C.length)+'%" class="block">'+C[B]+"</td>"}return A}function y5_addImportant(B){var A=/;/g;return B.replace(A," !important;")}function y5_closeBanner(B,C){if(B==y5_iR){var A=document.getElementById("y5"+y5_iR+"-banner");A.style.display="none"}}
