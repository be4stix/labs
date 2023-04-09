(function() {

var AdsLight = {};

var isVkDomain = (document.domain === 'vk.com');

var oneCpcAdInfo = {
  maxWidthVer:          118,
  maxWidthVerRepeatHor: 132,
  maxHeightVer:         254,
  maxWidthHor:          390,
  maxHeightHor:         100
};

var uaLight = navigator.userAgent.toLowerCase();
var browserLight = {
  msie6: (/msie 6/i.test(uaLight) && !/opera/i.test(uaLight)),
  msie7: (/msie 7/i.test(uaLight) && !/opera/i.test(uaLight)),
  mobile: /iphone|ipod|ipad|opera mini|opera mobi|iemobile/i.test(uaLight)
};

if (isVkDomain) {
  if (!('__adsLoaded' in window))      window.__adsLoaded      = vkNow();
  if (!('__adsCanShow' in window))     window.__adsCanShow     = 1;
  if (!('__adsParams' in window))      window.__adsParams      = false;
  if (!('__adsSection' in window))     window.__adsSection     = false;
  if (!('__adsImagesTimer' in window)) window.__adsImagesTimer = false;
  if (!('__adsActiveTab' in window))   window.__adsActiveTab   = false;
  if (!('__adsWrapVisible' in window)) window.__adsWrapVisible = false;
  if (!('__adsHandlers' in window))    window.__adsHandlers    = false;
  window.AdsLight = AdsLight;
}

AdsLight.init = function() {
  if (window.vk__adsLight) {
    return;
  }
  window.vk__adsLight = true;

  if (browserLight.mobile) {
    return;
  }

  var handlers = AdsLight.getHandlers();

  window.vk__adsLight = {};
  window.vk__adsLight.onInit = handlers.onInit;

  if ('onfocusin' in window) { // IE
    if (window.addEventListener) { // IE >= 9
      window.addEventListener('focusin', handlers.onFocusWindow, false);
      window.addEventListener('focusout', handlers.onBlurWindow, false);
    } else {
      if (window.attachEvent) { // IE < 9
        window.attachEvent('onfocusin', handlers.onFocusWindow);
        window.attachEvent('onfocusout', handlers.onBlurWindow);
      }
    }
  } else {
    if (window.addEventListener) { // Firefox, Opera, Google Chrome and Safari
      window.addEventListener('focus', handlers.onFocusWindow, true);
      window.addEventListener('blur', handlers.onBlurWindow, true);
    }
  }
  if (document.addEventListener) {
    document.addEventListener('mousedown', handlers.onMouseDownDocument, true);
  } else if (document.attachEvent) {
    document.attachEvent('onmousedown', handlers.onMouseDownDocument);
  }

  handlers.onInit();
}

AdsLight.getHandlers = function() {

  if (isVkDomain && __adsHandlers) {
    return __adsHandlers;
  }

  var needBlur       = false;
  var blurTime       = false;
  var afterClickLink = false;
  var updateTimer    = false;

  var handlers = {
    onInit:                    onInit,
    onHasFocus:                onHasFocus,
    onFocusWindow:             onFocusWindow,
    onBlurWindow:              onBlurWindow,
    onMouseDownDocument:       onMouseDownDocument,
    onMouseDownDocumentAction: onMouseDownDocumentAction,
    onCheckVisibleResult:      onCheckVisibleResult
  };

  if (isVkDomain) {
    __adsHandlers = handlers;
  }

  return handlers;

  function onInit() {
    if (document.hasFocus && document.hasFocus()) {
      onHasFocus();
    }
  }
  function onHasFocus() {
    if (window.VK && VK.Observer && VK.Observer.publish) {
      VK.Observer.publish('ads.onHasFocus');
    }

    if (isVkDomain) __adsActiveTab = true;
  }
  function onFocusWindow(event) {
    // Opera fix
    if (needBlur) {
      return;
    }

    if (window.VK && VK.Observer && VK.Observer.publish) {
      VK.Observer.publish('ads.onFocusWindow');
    }

    needBlur = true;
    if (isVkDomain) __adsActiveTab = true;

    if (window.vkNow && window.vk && !afterClickLink && blurTime && vkNow() - blurTime > (vk.adupd || 1800000)) {
      blurTime = false;
      updateTimer = setTimeout(function() {
        __adsLoaded = 0;
        AdsLight.updateBlock();
      }, 10);
    }
  }
  function onBlurWindow(event) {
    if (window.VK && VK.Observer && VK.Observer.publish) {
      VK.Observer.publish('ads.onBlurWindow');
    }

    if (!isVkDomain) {
      return;
    }

    needBlur = false;
    blurTime = vkNow();
    if (isVkDomain) __adsActiveTab = false;
  }
  function onMouseDownDocument(event) {
    if (window.VK && VK.Observer && VK.Observer.publish) {
      VK.Observer.publish('ads.onMouseDownDocument');
    }

    if (isVkDomain) __adsActiveTab = true;

    if (!event) {
      return;
    }
    var elem = event.target;
    while (elem) {
      if (elem.tagName == 'A') {
        break;
      }
      if (elem.onclick) {
        break;
      }
      elem = elem.parentNode;
    }
    if (!elem) {
      return;
    }

    onMouseDownDocumentAction();
  }
  function onMouseDownDocumentAction() {
    if (window.VK && VK.Observer && VK.Observer.publish) {
      VK.Observer.publish('ads.onMouseDownDocumentAction');
    }

    clearTimeout(updateTimer);

    afterClickLink = true;
    setTimeout(function() {
      afterClickLink = false;
    }, 10);
  }
  function onCheckVisibleResult(isBlockWrapVisible) {
    __adsWrapVisible = isBlockWrapVisible;
  }
}

AdsLight.canUpdate = function() {

  var containerElem = ge('left_ads');

  var result = true;

  // Is visible
  result = (result && __adsActiveTab && containerElem && isVisible(containerElem) && AdsLight.isVisibleBlockWrap());
  // Is reasonable
  result = (result && vk.id && (__adsCanShow >= 1 || (vkNow() + __adsCanShow > 3600000))); // hour

  if (__adsSection !== 'web') {
    // Is visible
    result = (result && isVisible('side_bar') && !layers.visible && !isVisible('left_friends'));
    // Is reasonable
    result = (result && vk.loaded && !vk.no_ads);
  }

  return result;
}

AdsLight.getAjaxParams = function(ajaxParams, ajaxOptions) {
  var ajaxParamsNew = {};
  var canUpdateBlock = AdsLight.canUpdate();
  if (ajaxOptions.noAds) {
    ajaxParamsNew.al_ad = 0;
  } else if (canUpdateBlock || ajaxOptions.ads) {
    if (ajaxOptions.ads || __adsSection !== 'web' && (vkNow() - __adsLoaded > (vk.adupd || 1800000))) { // 30 min
      __adsLoaded = vkNow();
      ajaxParamsNew.al_ad = 1;
    }
    if (ajaxParams.al_ad || ajaxParamsNew.al_ad) {
      ajaxParamsNew.ads_section = __adsSection;
    }
  } else {
    ajaxParamsNew.al_ad = null;
  }
  return ajaxParamsNew;
}

AdsLight.updateBlock = function(noDelay) {

  var canUpdateBlock = AdsLight.canUpdate();

  if (!noDelay) {
    setTimeout(AdsLight.updateBlock.pbind(true), 50);
    return;
  }

  if (canUpdateBlock && !__adsLoaded) {
    __adsLoaded = vkNow();
    var ajaxParams = {};
    ajaxParams = extend({}, ajaxParams, __adsParams);
    ajax.post('/ads_rotate.php?act=al_update_ad', ajaxParams, {ads: 1});
  }
}

AdsLight.setNewBlock = function(adsHtml, adsSection, adsCanShow, adsParams) {
  if (typeof(adsSection) === 'string') {
    __adsSection = adsSection;
  }
  __adsCanShow = ((adsCanShow || adsCanShow === '0') ? 1 : -vkNow());
  if (adsParams) {
    __adsParams = adsParams;
  }

  if (!adsHtml) {
    if (vk.no_ads) {
      adsHtml = '';
    } else if (__adsSection === 'im' && __seenAds == 0) {
      adsHtml = '';
    } else {
      AdsLight.resizeBlockWrap([0,0], false, false, true);
      return;
    }
  }

  __adsLoaded = vkNow();

  var containerElem = ge('left_ads');
  var isContainerVisible = (containerElem && isVisible(containerElem) || vk.ad_preview);
  if (!containerElem) {
    var sideBarElem = ge('side_bar');
    if (!sideBarElem) {
      AdsLight.resizeBlockWrap([0,0], false, false, true);
      return;
    }
    containerElem = sideBarElem.appendChild(ce('div', {id: 'left_ads'}, {display: isContainerVisible ? 'block' : 'none'}));
  }

  AdsLight.showNewBlock(containerElem, adsHtml, isContainerVisible);
}

AdsLight.showNewBlock = function(containerElem, adsHtml, isContainerVisible) {
  if (!isContainerVisible || browserLight.msie6 || browserLight.msie7) {
    if (!isContainerVisible) {
      debugLog('Ads container is hidden');
    }
    containerElem.innerHTML = adsHtml;
    var newSize = AdsLight.getBlockSize(containerElem);
    AdsLight.resizeBlockWrap(newSize, false, false, true);
    AdsLight.updateExternalStats(containerElem);
    return;
  }

  var isNewBlockEmpty  = !adsHtml;
  var speed            = (isNewBlockEmpty ? 0 : 200);
  var oldSize          = AdsLight.getBlockSize(containerElem);
  var lastSize         = [0, 0];
  var newBlockElem     = containerElem.appendChild(ce('div', {innerHTML: adsHtml}, {display: 'none'}));
  var newBlockSizeElem = (geByClass1('ads_ads_box3', newBlockElem) || newBlockElem);

  var imagesElems   = geByTag('img', newBlockElem);
  var imagesObjects = [];
  for (var i = 0, len = imagesElems.length; i < len; i++) {
    var imageObject = vkImage();
    imageObject.onload  = delayedResizeBlockWrap;
    imageObject.onerror = delayedResizeBlockWrap;
    imageObject.src = imagesElems[i].src;
    imagesObjects.push(imageObject);
  }

  // Wait images then show ads
  clearInterval(__adsImagesTimer);
  __adsImagesTimer = setInterval(waitIamges.pbind({count: 40}), 50); // 2 seconds

  function waitIamges(context) {
    if (--context.count > 0) {
      for (var i in imagesObjects) {
        if (!imagesObjects[i].width || !imagesObjects[i].height) {
          return;
        }
      }
    }
    clearInterval(__adsImagesTimer);
    startShowing();
  }
  function delayedResizeBlockWrap() {
    if (isVisible(newBlockElem)) {
      var newSize = AdsLight.getBlockSize(newBlockSizeElem);
      newSize = AdsLight.resizeBlockWrap(newSize, oldSize, lastSize);
    }
  }
  function startShowing() {
    setStyle(containerElem, {overflow: 'hidden'});
    // zIndex: 10 - To be upper then previous block and hiders after closing ads
    // width: '100%' - For correct horizontal centering.
    setStyle(newBlockElem, {display: 'block', position: 'absolute', left: 0, top: 0, opacity: 0, zIndex: 10, width: '100%'});

    var newSize = AdsLight.getBlockSize(newBlockSizeElem);
    newSize = AdsLight.resizeBlockWrap(newSize, oldSize, lastSize);

    // Resize container
    animate(containerElem, {width: newSize[0], height: newSize[1]}, speed, showNewBlock.pbind());
  }
  function showNewBlock() {
    var newSize = AdsLight.getBlockSize(newBlockSizeElem)
    newSize = AdsLight.resizeBlockWrap(newSize, false, lastSize, true);

    animate(newBlockElem, {opacity: 1}, speed, removeOldBlock);
  }
  function removeOldBlock() {
    while (newBlockElem.previousSibling) {
      re(newBlockElem.previousSibling);
    }
    setStyle(newBlockElem, {position: 'static', zIndex: '', width: ''});
    setStyle(containerElem, {width: '', height: '', overflow: 'visible'});

    // Update site layout
    if (window.updSideTopLink) updSideTopLink();

    AdsLight.updateExternalStats(containerElem);
  }
}

AdsLight.updateExternalStats = function(containerElem) {
  var elems = geByClass('ads_ad_external_stats', containerElem);
  for (var i = 0, elem; elem = elems[i]; i++) {
    if (elem.getAttribute('external_stats_complete')) {
      continue;
    }
    elem.setAttribute('external_stats_complete', 1);
    vkImage().src = elem.getAttribute('external_stats_src');
  }
}

AdsLight.isVisibleBlockWrap = function() {
  if (__adsSection === 'web') {
    if (cur.checkVisibleWidget) {
      var isAdTypeHorizontal     = (__adsParams && __adsParams.ads_ad_type === 'horizontal');
      var isAdUnitTypeHorizontal = (__adsParams && __adsParams.ads_ad_unit_type === 'horizontal');
      var oneAdMaxWidth;
      var oneAdMaxHeight;
      if (isAdTypeHorizontal) {
        oneAdMaxWidth  = oneCpcAdInfo.maxWidthHor;
        oneAdMaxHeight = oneCpcAdInfo.maxHeightHor;
      } else {
        oneAdMaxWidth  = (isAdUnitTypeHorizontal ? oneCpcAdInfo.maxWidthVerRepeatHor : oneCpcAdInfo.maxWidthVer);
        oneAdMaxHeight = oneCpcAdInfo.maxHeightVer;
      }
      cur.checkVisibleWidget(oneAdMaxWidth, oneAdMaxHeight);
    }
  } else {
    var containerElem = ge('left_ads');
    var containerTop  = (getXY(containerElem, true) || {})[1];
    var scrollTop     = scrollGetY();
    __adsWrapVisible  = ((containerTop + oneCpcAdInfo.maxHeightVer > scrollTop) && (containerTop < scrollTop + lastWindowHeight));
  }
  return __adsWrapVisible;
}

AdsLight.getBlockSize = function(blockElem) {
  var adBoxes = geByClass('ads_ad_box5', blockElem);
  each(adBoxes, function(key, value) { addClass(value, 'max_size'); });
  var blockWidth  = Math.ceil(floatval(getStyle(blockElem, 'width')));
  var blockHeight = Math.ceil(floatval(getStyle(blockElem, 'height')));
  var blockSize = [blockWidth, blockHeight];
  each(adBoxes, function(key, value) { removeClass(value, 'max_size'); });
  return blockSize;
}

AdsLight.resizeBlockWrap = function(newSize, oldSize, lastSize, forceResize) {
  if (!newSize) {
    return [0, 0];
  }

  var newWidth  = newSize[0];
  var newHeight = newSize[1];
  if (newWidth && __adsParams && __adsParams.ads_ad_unit_width > newWidth) {
    newWidth = __adsParams.ads_ad_unit_width;
  }
  if (newHeight && __adsParams && __adsParams.ads_ad_unit_height > newHeight) {
    newHeight = __adsParams.ads_ad_unit_height;
  }
  var isResizeWidth  = !!(forceResize || oldSize && newWidth > oldSize[0] || lastSize && lastSize[0] && newWidth > lastSize[0]);
  var isResizeHeight = !!(forceResize || oldSize && newHeight > oldSize[1] || lastSize && lastSize[1] && newHeight > lastSize[1]);
  if (!isResizeWidth && !isResizeHeight) {
    return [newWidth, newHeight];
  }
  if (lastSize) {
    if (isResizeWidth) {
      lastSize[0] = newWidth;
    }
    if (isResizeHeight) {
      lastSize[1] = newHeight;
    }
  }

  if (__adsSection === 'web') {
    if (cur.resizeWidget) cur.resizeWidget(isResizeWidth && newWidth, isResizeHeight && newHeight);
  }

  return [newWidth, newHeight];
}

AdsLight.handleAllAds = function(box, adsIdsMore, adsIdsApply, adsHeightMore) {

  var moreLocked    = false;
  var applyLocked   = false;
  var needAdsHeight = false;
  var needAdsApply  = {};
  var applyAllowed  = false;

  boxLayerWrap.scrollTop = 0;

  var boxOptions = {};
  boxOptions.onClean = deinit;
  box.setOptions(boxOptions);

  if (adsIdsMore) {
    addEvent(boxLayerWrap, 'scroll', onScroll);
  }
  allowApply();
  onScroll();

  function deinit() {
    removeEvent(boxLayerWrap, 'scroll', onScroll);
    hide('ads_ads_all_ads_more');
  }
  function checkDeinit() {
    if (!adsIdsMore && isEmpty(adsIdsApply)) {
      deinit();
    }
  }
  function allowApply(delayed) {
    if (!delayed) {
      setTimeout(allowApply.pbind(true), 1000);
      return;
    }
    applyAllowed = true;
    onScroll();
  }
  function onScroll() {
    var moreElem = ge('ads_ads_all_ads_more');
    if (!moreElem) {
      return;
    }
    var moreRect = moreElem.getBoundingClientRect()
    if (moreRect.top < lastWindowHeight + adsHeightMore) {
      needAdsHeight = Math.round(Math.max(needAdsHeight, lastWindowHeight - moreRect.top + adsHeightMore));
      moreAds();
    }

    if (applyAllowed) {
      var isApplyAdsUpdated = false;
      for (var i in adsIdsApply) {
        if (needAdsApply[i]) {
          continue;
        }
        adsRowRect = ge(i).getBoundingClientRect();
        if (adsRowRect.bottom > 0 && adsRowRect.top < lastWindowHeight) {
          needAdsApply[i] = true;
          isApplyAdsUpdated = true;
        }
      }
      if (isApplyAdsUpdated) {
        applyAds();
      }
    }
  }
  function moreAds(delayed) {
    if (!delayed) {
      setTimeout(moreAds.pbind(true), 100);
      return;
    }
    if (!adsIdsMore) {
      return;
    }
    if (!needAdsHeight) {
      return;
    }
    if (moreLocked) {
      return;
    }
    moreLocked = true;

    var ajaxParams = {};
    ajaxParams.ads_ids_more = adsIdsMore;
    ajaxParams.ads_height = needAdsHeight;

    ajax.post('/ads_light.php?act=all_ads_more', ajaxParams, {onDone: onDoneMoreAds.pbind(), onFail: onFailMoreAds})
  }
  function onDoneMoreAds(response) {
    moreLocked = false;
    if (!response) {
      onFailMoreAds();
      return;
    }
    adsIdsMore = response.ads_ids_more;
    for (var i in response.ads_ids_apply) {
      adsIdsApply[i] = response.ads_ids_apply[i];
    }
    if (response.ads_html) {
      var adsElem = ge('ads_ads_all_ads_rows');
      var moreElem = ge('ads_ads_all_ads_more');
      if (adsElem) {
        adsElem.innerHTML += response.ads_html;
        needAdsHeight = false;
        onScroll();
      }
      if (moreElem) {
        moreElem.height = response.ads_more_height;
      }
    }
    checkDeinit();
  }
  function onFailMoreAds() {
    moreLocked = false;
    return true;
  }
  function applyAds(delayed) {
    if (!delayed) {
      setTimeout(applyAds.pbind(true), 100);
      return;
    }
    if (isEmpty(adsIdsApply)) {
      checkDeinit();
      return;
    }
    if (isEmpty(needAdsApply)) {
      return;
    }
    if (applyLocked) {
      return;
    }
    applyLocked = true;

    var ajaxParams = {};
    ajaxParams.ads_ids_apply = [];

    for (var i in needAdsApply) {
      ajaxParams.ads_ids_apply.push(adsIdsApply[i]);
      delete adsIdsApply[i];
    }
    needAdsApply = {};

    ajaxParams.ads_ids_apply = ajaxParams.ads_ids_apply.join(';');

    ajax.post('/ads_light.php?act=all_ads_apply', ajaxParams, {onDone: onCompleteApplyAds, onFail: onCompleteApplyAds})
  }
  function onCompleteApplyAds(response) {
    applyLocked = false;
    applyAds();
  }
}

AdsLight.init();

})();

try{stManager.done('aes_light.js');}catch(e){}
