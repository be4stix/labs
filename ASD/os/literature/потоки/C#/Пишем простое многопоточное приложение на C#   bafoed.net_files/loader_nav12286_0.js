var navMap = {'<void>':['al_index.php',['index.css','index.js']],'<other>':['al_profile.php',['profile.css','page.css','profile.js','page.js']],'public\\d+($|/)':['al_public.php',['public.css','page.css','public.js','page.js']],'event\\d+($|/)':['al_events.php',['events.css','page.css','events.js','page.js']],'club\\d+($|/)':['al_groups.php',['groups.css','page.css','groups.js','page.js']],'publics\\d+($|/)':['al_public.php',['public.css','page.css','public.js','page.js']],'groups(\\d+)?$':['al_groups.php',['groups.css','groups_list.js','indexer.js']],'events$':['al_events.php',['events.css','page.css','events.js','page.js']],'changemail$':['register.php',['reg.css']],'mail($|/)':['al_mail.php',['mail.css','mail.js']],'write\\d*($|/)':['al_mail.php',['mail.css','mail.js']],'im($|/)':['al_im.php',['im.css','im.js']],'audio-?\\d+_\\d+$':['al_audio.php',['audio.css','audio.js']],'audios(-?\\d+)?$':['al_audio.php',['audio.css','audio.js']],'audio($|/)':['al_audio.php',['audio.css','audio.js']],'apps_check($|/)':['al_apps_check.php',['apps.css','apps.js']],'apps($|/)':['al_apps.php',['apps.css','apps.js']],'editapp($|/)':['al_apps_edit.php',['apps.css','apps.js']],'regstep\\d$':['register.php',['reg.js','reg.css','ui_controls.js','ui_controls.css','selects.js']],'video(-?\\d+_\\d+)?$':['al_video.php',['video.js','video.css','videoview.js','videoview.css','indexer.js']],'videos(-?\\d+)?$':['al_video.php',['video.js','video.css','indexer.js']],'feed$':['al_feed.php',['page.css','page.js','feed.css','feed.js']],'friends$':['al_friends.php',['friends.js','friends.css','privacy.css']],'friendsphotos$':['al_photos.php',['friendsphotos.js','photoview.js','friendsphotos.css','photoview.css']],'wall-?\\d+(_\\d+)?$':['al_wall.php',['page.js','page.css','wall.js','wall.css']],'tag\\d+$':['al_photos.php',['photos.js','photoview.js','photos.css','photoview.css']],'albums(-?\\d+)?$':['al_photos.php',['photos.js','photos.css']],'photos(-?\\d+)?$':['al_photos.php',['photos.js','photos.css']],'album-?\\d+_\\d+$':['al_photos.php',['photos.js','photos.css']],'photo-?\\d+_\\d+$':['al_photos.php',['photos.js','photos.css','photoview.js','photoview.css']],'search$':['al_search.php',['search.css','search.js']],'invite$':['invite.php',['invite.css','invite.js','ui_controls.css','ui_controls.js']],'join$':['join.php',['join.css','join.js']],'settings$':['al_settings.php',['settings.js','settings.css']],'edit$':['al_profileEdit.php',['profile_edit.js','profile_edit.css']],'blog$':['blog.php',['blog.css']],'fave$':['al_fave.php',['fave.js','fave.css','page.css','wall.css','qsorter.js','indexer.js']],'topic$':['al_board.php',['board.css']],'board\\d+$':['al_board.php',['board.css','board.js']],'topic-?\\d+_\\d+$':['al_board.php',['board.css','board.js']],'stats($|/)':['al_stats.php',['stats.css']],'ru/(.*)?$':['al_pages.php',['pages.css','pages.js','wk.css','wk.js']],'pages($|/)':['al_pages.php',['pages.css','pages.js','wk.css','wk.js']],'page-?\\d+_\\d+$':['al_pages.php',['pages.css','pages.js','wk.css','wk.js']],'restore($|/)':['al_restore.php',['restore.js','restore.css']],'recover($|/)':['recover.php',['recover.js','recover.css']],'gifts\\d*$':['al_gifts.php',['gifts.js','gifts.css']],'docs($|/)':['docs.php',['docs.css','docs.js','indexer.js']],'doc-?\\d+_\\d+$':['docs.php',['docs.css','docs.js','indexer.js']],'docs-?\\d+$':['docs.php',['docs.css','docs.js','indexer.js']],'login($|/)':['al_login.php',['login.css']],'tasks($|/)':['tasks.php',['tasks.css','tasks.js']],'abuse($|/)':['abuse.php',['abuse.css','abuse.js']],'support($|/)':['al_tickets.php',['tickets.css','tickets.js']],'helpdesk($|/)':['al_helpdesk.php',['tickets.css','tickets.js']],'offersdesk($|/)':['offers.php',['offers.css','offers.js']],'payments($|/)':['al_payments.php',['payments.css']],'faq($|/)':['al_faq.php',['faq.css','faq.js']],'tlmd($|/)':['al_talmud.php',['faq.js','faq.css','tickets.css','tickets.js']],'sms_office($|/)':['sms_office.php',['sms_office.css','sms_office.js']],'dev($|/)':['dev.php',['dev.css','dev.js']],'developers($|/)':['al_developers.php',['developers.css']],'help($|/)':['al_help.php',['help.css','help.js']],'claims($|/)':['al_claims.php',['claims.css','claims.js']],'ads$':['ads.php',['ads.css','ads.js']],'adbonus$':['ads.php',['ads.css','ads.js']],'adsbonus$':['ads.php',['ads.css','ads.js']],'adregister$':['ads.php',['ads.css','ads.js']],'adsedit$':['ads_edit.php',['ads.css','ads.js','ads_edit.css','ads_edit.js']],'adscreate$':['ads_edit.php',['ads.css','ads.js','ads_edit.css','ads_edit.js']],'adsmoder$':['ads_moder.php',['ads.css','ads.js','ads_moder.css','ads_moder.js']],'adsweb$':['ads_web.php',['ads.css','ads.js','ads_web.css','ads_web.js']],'test$':['al_help.php',['help.css','help.js']],'agenttest$':['al_help.php',['help.css','help.js']],'grouptest$':['al_help.php',['help.css','help.js']],'dmca$':['al_help.php',['help.css','help.js']],'terms$':['al_help.php',['help.css','help.js']],'privacy$':['al_help.php',['help.css','help.js']],'note\\d+_\\d+$':['al_wall.php',['wall.js','wall.css','wk.js','wk.css','pagination.js']],'notes(\\d+)?$':['al_wall.php',['wall.js','wall.css','wk.js','wk.css','pagination.js']],'bugs($|/)':['bugs.php',['bugs.css','bugs.js']],'wkview.php($)':['wkview.php',['wkview.js','wkview.css','wk.js','wk.css']],'stickers_office($|/)':['stickers_office.php',['stickers_office.css','stickers_office.js']]}; var stVersions = { 'nav': 12286, 'common.js': 1063, 'common.css': 399, 'pads.js': 51, 'pads.css': 52, 'retina.css': 102, 'uncommon.js': 9, 'uncommon.css': 51, 'filebutton.css': 9, 'filebutton.js': 9, 'lite.js': 65, 'lite.css': 21, 'ie6.css': 26, 'ie7.css': 18, 'rtl.css': 135, 'pagination.js': 18, 'blog.css': 7, 'html5audio.js': 5, 'html5video.js': 20, 'html5video.css': 3, 'audioplayer.js': 84, 'audioplayer.css': 9, 'audio_html5.js': 7, 'audio.js': 156, 'audio.css': 87, 'gifts.css': 35, 'gifts.js': 34, 'indexer.js': 13, 'graph.js': 30, 'graph.css': 1, 'boxes.css': 22, 'box.js': 5, 'rate.css': 4, 'tooltips.js': 65, 'tooltips.css': 77, 'player.js': 61, 'sorter.js': 17, 'qsorter.js': 17, 'phototag.js': 5, 'phototag.css': 2, 'photoview.js': 298, 'photoview.css': 148, 'friendsphotos.js': 13, 'friendsphotos.css': 17, 'friends.js': 188, 'friends.css': 129, 'friends_search.js': 10, 'friends_search.css': 6, 'board.js': 59, 'board.css': 43, 'photos.css': 67, 'photos.js': 64, 'photos_add.css': 17, 'photos_add.js': 34, 'wkpoll.js': 11, 'wkview.js': 98, 'wkview.css': 75, 'single_pv.css': 9, 'single_pv.js': 4, 'video.js': 113, 'video.css': 94, 'videoview.js': 168, 'videoview.css': 98, 'video_edit.js': 17, 'video_edit.css': 15, 'translation.js': 13, 'translation.css': 5, 'reg.css': 26, 'reg.js': 56, 'invite.css': 11, 'invite.js': 10, 'prereg.js': 14, 'index.css': 19, 'index.js': 25, 'join.css': 55, 'join.js': 83, 'intro.css': 21, 'owner_photo.js': 17, 'owner_photo.css': 10, 'page.js': 664, 'page.css': 541, 'about.css': 1, 'page_fixed.css': 18, 'page_help.css': 13, 'public.css': 56, 'public.js': 39, 'events.css': 30, 'events.js': 37, 'pages.css': 47, 'pages.js': 40, 'groups.css': 82, 'groups.js': 29, 'groups_list.js': 45, 'groups_edit.css': 31, 'groups_edit.js': 55, 'profile.css': 196, 'profile.js': 197, 'calendar.css': 5, 'calendar.js': 10, 'wk.css': 34, 'wk.js': 13, 'pay.css': 3, 'pay.js': 6, 'tagger.js': 13, 'tagger.css': 13, 'qsearch.js': 11, 'wall.css': 64, 'wall.js': 59, 'walledit.js': 30, 'mail.css': 69, 'mail.js': 86, 'email.css': 2, 'im.css': 205, 'im.js': 61, 'wide_dd.css': 12, 'wide_dd.js': 25, 'writebox.js': 7, 'sharebox.js': 4, 'fansbox.js': 20, 'feed.js': 311, 'feed.css': 176, 'privacy.js': 81, 'privacy.css': 48, 'apps.css': 130, 'apps.js': 201, 'apps_edit.js': 64, 'apps_edit.css': 59, 'apps_check.js': 21, 'apps_check.css': 20, 'settings.js': 75, 'settings.css': 56, 'profile_edit.js': 61, 'profile_edit.css': 26, 'profile_edit_edu.js': 3, 'profile_edit_job.js': 1, 'profile_edit_mil.js': 1, 'search.js': 90, 'search.css': 63, 'datepicker.js': 14, 'datepicker.css': 4, 'oauth_popup.css': 22, 'oauth_page.css': 12, 'oauth_touch.css': 3, 'notes.css': 18, 'notes.js': 29, 'wysiwyg.js': 46, 'wysiwyg.css': 33, 'wiki.css': 9, 'fave.js': 47, 'fave.css': 47, 'widget_comments.css': 58, 'widget_community.css': 42, 'api/widgets/al_comments.js': 74, 'api/widgets/al_poll.js': 4, 'api/widgets/al_community.js': 32, 'al_poll.css': 3, 'widget_recommended.css': 3, 'developers.css': 6, 'touch.css': 7, 'notifier.js': 222, 'notifier.css': 69, 'restore.js': 18, 'restore.css': 11, 'recover.js': 1, 'recover.css': 3, 'docs.js': 48, 'docs.css': 53, 'tags_dd.js': 14, 'tags_dd.css': 11, 'tasks.js': 22, 'tasks.css': 29, 'tickets.js': 105, 'tickets.css': 95, 'faq.js': 12, 'faq.css': 17, 'bugs.js': 9, 'bugs.css': 7, 'login.css': 32, 'upload.js': 76, 'graffiti.js': 25, 'graffiti.css': 21, 'abuse.js': 13, 'abuse.css': 17, 'verify.css': 4, 'stats.css': 22, 'payments.css': 27, 'payments.js': 6, 'offers.css': 17, 'offers.js': 23, 'call.js': 72, 'call.css': 13, 'aes_light.css': 23, 'aes_light.js': 9, 'ads.css': 41, 'ads.js': 34, 'ads_edit.css': 15, 'ads_edit.js': 57, 'ads_moder.css': 17, 'ads_moder.js': 11, 'ads_tagger.js': 1, 'ads_web.css': 10, 'ads_web.js': 22, 'health.css': 11, 'health.js': 5, 'pinbar.js': 3, 'sms_office.css': 17, 'sms_office.js': 11, 'help.css': 17, 'help.js': 11, 'claims.css': 3, 'claims.js': 2, 'site_stats.css': 8, 'site_stats.js': 4, 'meminfo.css': 7, 'blank.css': 1, 'wk_editor.js': 61, 'wk_editor.css': 25, 'btagger.js': 12, 'btagger.css': 11, 'filters.js': 50, 'dev.js': 31, 'dev.css': 38, 'stickers_office.css': 1, 'stickers_office.js': 1, 'ui_controls.js': 128, 'ui_controls.css': 33, 'selects.js': 22, 'mentions.js': 50, 'apps_flash.js': 64, 'maps.js': 11, 'places.js': 28, 'places.css': 30, 'map2.js': 4, 'map.css': 4, 'sort.js': 8, 'paginated_table.js': 49, 'paginated_table.css': 8, 'q_frame.php': 6, '/swf/api_wrapper.swf': 4, '/swf/api_external.swf': 4, '/swf/api_wrapper2_0.swf': 2, '/swf/queue_transport.swf': 5, '/swf/audio_lite.swf': 10, '/swf/uploader_lite.swf': 6, '/swf/photo_uploader_lite.swf': 9, '/swf/CaptureImg.swf': 7, '/swf/VideoPlayer3_4.swf': 6, '/swf/VideoPlayer3_5.swf': 6, '/swf/VideoPlayer4_0.swf': 50, '/swf/vkvideochat.swf': 46, '/swf/vchatdevices.swf': 1, 'lang': 6450}; var stTypes = {fromLib:{'md5.js':1,'ui_controls.js':1,'selects.js':1,'sort.js':1,'maps.js':1},fromRoot:{'api/openapi.js':1,'apps_flash.js':1,'mentions.js':1,'map2.js':1,'ui_controls.css':1,'map.css':1,'paginated_table.js':1,'paginated_table.css':1}}; var _rnd = 6148;