function () {
    'use strict';
    window.configElements = [] ==
        BEGIN UI BUILDING ==
        window.overlay = document.createElement(div)
    window.overlay.style.width = 100 vw
    window.overlay.style.height = 100 vh
    window.overlay.style.zIndex = 1
    window.overlay.style.position = fixed
    window.overlay.style.visibility = hidden
    window.overlay.id = overlay
    document.body.prepend(window.overlay)

    function BuildMenuEntry(name, info, id, configpane) {
        window.entry = document.createElement(div)
        window.tickbox = document.createElement(input)
        window.tickbox.type = checkbox
        window.tickbox.id = id
        window.configElements.push(id)
        window.entry.appendChild(window.tickbox)
        window.window.label = document.createElement(label)
        window.label.innerText = name
        window.entry.appendChild(window.label)
        if (configpane != undefined) {
            window.configbutton = document.createElement(button)
            window.configbutton.innerText = Configure
            window.configbutton.style.marginLeft = 7 px
            window.configbutton.style.border = 1 px solid #5f5f5f
            window.configbutton.style.boxShadow = inset 0 0 5 px rgba(0, 0, 0, 0.6)
            window.configbutton.style.backgroundColor = rgb(39, 39, 39)
            window.configbutton.style.color = #f9a619
            window.configbutton.style.borderRadius = 3 px
            window.configbutton.onclick = function () {
                if (document.getElementById(configpane)
                    .style.visibility == unset) {
                    document.getElementById(configpane)
                        .style.visibility = hidden
                } else {
                    document.getElementById(configpane)
                        .style.visibility = unset
                }
            }
            window.entry.appendChild(window.configbutton)
        }
        window.desc = document.createElement(p)
        window.desc.innerHTML = info;
        window.entry.appendChild(window.desc)
        return window.entry
    }

    function RenderPane(name, id, width, height, margintop, marginleft) {
        window.pane = document.createElement(div)
        window.pane.style.width = width
        window.pane.style.height = height
        window.pane.style.position = absolute
        window.pane.style.marginTop = margintop
        window.pane.style.marginLeft = marginleft
        window.pane.style.border = 1 px solid rgb(95, 95, 95)
        window.pane.style.borderRadius = 3 px
        window.pane.style.backgroundColor = rgb(39, 39, 39)
        window.pane.style.overflow = hidden
        window.pane.style.color = rgb(249, 166, 25)
        window.pane.style.textAlign = center
        window.pane.style.overflowY = scroll
        window.pane.id = id
        window.panetitle = document.createElement(h1)
        window.panetitle.innerText = name
        window.pane.appendChild(window.panetitle)
        window.pane.appendChild(document.createElement(hr))
        document.getElementById(overlay)
            .appendChild(window.pane)
    }
    Add the button
    window.tweaksbutton = document.createElement(button)
    window.tweaksbutton.innerText = Tweaks
    window.tweaksbutton.id = tweaksbutton
    window.tweaksbutton.style.border = 1 px solid #5f5f5f
    window.tweaksbutton.style.boxShadow = inset 0 0 5 px rgba(0, 0, 0, 0.6)
    window.tweaksbutton.style.backgroundColor = rgb(39, 39, 39)
    window.tweaksbutton.style.color = #f9a619
    window.tweaksbutton.style.borderRadius = 3 px
    window.tweaksbutton.style.marginLeft = 40 %
        window.tweaksbutton.style.zIndex = 2

    document.getElementsByClassName(mainfoot)[0].appendChild(window.tweaksbutton)
    Build main menu
    RenderPane(EdgenTweaks, tweaksmenu, 50 % , 50 % , 20 vh, 25 % )
    Menu Entrys
    document.getElementById(tweaksmenu)
        .appendChild(BuildMenuEntry(Auto Advance, Advance to the next portion of the course automatically when it becomes available, AutoAdvance.tickbox))
    document.getElementById(tweaksmenu)
        .appendChild(BuildMenuEntry(Auto Complete Vocab, Automatically completes vocab assignments, AutoCompleteVocabTickbox))
    document.getElementById(tweaksmenu)
        .appendChild(BuildMenuEntry(Skip Videos, Skips videos.span style = 'color red'
            THIS IS HIGHLY EXPERIMENTAL AND WILL BREAK THINGSspan, SkipVideosTickbox))
    document.getElementById(tweaksmenu)
        .appendChild(BuildMenuEntry(Skip intro, Lets you interact with practices
            while the intro audio is playing, SkipIntro.tickbox))
    document.getElementById(tweaksmenu)
        .appendChild(BuildMenuEntry(Guess Practice, Most teachers don 't count practices twords your final grade, so you can guess your way thru them. This automatically guesses thru practices., GuessPractice.tickbox, practiceconfig))
                document.getElementById(tweaksmenu)
                .appendChild(BuildMenuEntry(Show Columns, On practices where you have to write a text response to a prompt, there is an example response to the prompt.However, it is hidden until you submit your response.This forces it to show even
                    if you haven 't submitted a response yet, ShowColumn.tickbox))
                    Config Menus RenderPane(Guess Practice Config, practiceconfig, 15 % , 15 % , 0, 0) document.getElementById(practiceconfig)
                    .style.visibility = hidden document.getElementById(practiceconfig)
                    .appendChild(BuildMenuEntry(Guess thru Assignments, Guesses thru assignments.This is highly discouraged, guessassignments)) window.copyright window.copyright = document.createElement(p) window.copyright.innerHTML = EdgenTweaks Version 1.2 .9 by Gradyn Wursten(a href = 'httpshost.gradyn.comedgentweakssupport.html'
                        Support the project!a) window.copyright.style.color = gray window.copyright.style.width = 100 %
                    document.getElementById(tweaksmenu)
                    .append(window.copyright) Activate the button document.getElementById(tweaksbutton)
                    .addEventListener(click, function () {
                        if (document.getElementById(overlay)
                            .style.visibility == hidden) {
                            document.getElementById(overlay)
                                .style.visibility = visible
                        } else {
                            document.getElementById(overlay)
                                .style.visibility = hidden
                        }
                    })


                    ==
                    BEGIN TWEAKS ==
                    Auto Advance
                    function autoadvance() {
                        if (document.getElementById(AutoAdvance.tickbox)
                            .checked) {
                            if (document.getElementById(activity - title)
                                .innerText == Quiz) {} else {
                                try {
                                    document.getElementsByClassName(footnav goRight)[0].click()
                                } catch (TypeError) {}
                                try {
                                    window.frames[0].API.FrameChain.nextFrame()
                                } catch (TypeError) {}
                            }
                        }
                    }
                    Skip intro
                    function skipIntro() {
                        if (document.getElementById(SkipIntro.tickbox)
                            .checked) {
                            try {
                                window.frames[0].document.getElementById(invis - o - div)
                                    .remove()
                            } catch (TypeError) {}
                        }
                    }
                    Guess Practice
                    function GuessPractice() {
                        if (document.getElementById(GuessPractice.tickbox)
                            .checked) {
                            try {
                                document.getElementById(activity - title) may error
                                if (document.getElementById(activity - title)
                                    .innerText == Assignment) {
                                    if (!document.getElementById(guessassignments)
                                        .checked) {
                                        return End the method call so we dont guess
                                    }
                                }
                                if ([Instruction, Assignment, Warm - Up].includes(document.getElementById(activity - title)
                                        .innerText)) {
                                    try {
                                        window.options = window.frames[0].frames[0].document.getElementsByClassName(answer - choice - button);
                                        window.options[Math.floor(Math.random() window.options.length)].click();
                                    } catch (TypeError) {}
                                    try {
                                        window.frames[0].API.Frame.check()
                                    } catch (TypeError) {}
                                    This has to be seporate from the option clicker in
                                    case it 's a text only practice
                                }
                            } catch (TypeError) {}
                        }
                    }
                    Unhide Right Column
                    function showColumn() {
                        if (document.getElementById(ShowColumn.tickbox)
                            .checked) {
                            try {
                                window.frames[0].frames[0].document.getElementsByClassName(right - column)[0].children[0].style.display = block
                            } catch (TypeError) {}
                            try {
                                window.frames[0].frames[0].document.getElementsByClassName(left - column)[0].children[0].style.display = block
                            } catch (TypeError) {}
                        }
                    }
                    Skip videos(PATCHED)
                    function skipVideo() {
                        if (document.getElementById(SkipVideosTickbox)
                            .checked) {
                            if (document.getElementById(activity - title)
                                .innerText != Assignment) {
                                Appearantly this causes problems with assignments, disable it
                                for now
                                if (frames[0].document.getElementById(home_video_container)
                                    .parentNode.style.opacity == 1) {
                                    try {
                                        window.frames[0].API.FrameChain.framesStatus[window.frames[0].API.FrameChain.currentFrame - 1] = complete
                                    } catch (TypeError) {}
                                }
                            }
                        }
                    }
                    Auto complete vocab
                    function vocabCompleter() {
                        if (document.getElementById(AutoCompleteVocabTickbox)
                            .checked) {
                            if (document.getElementById(activity - title)
                                .innerText == Vocabulary) {
                                try {
                                    window.frames[0].document.getElementsByClassName(word - textbox)[0].value = window.frames[0].document.getElementsByClassName(word - background)[0].value
                                } catch (TypeError) {}
                                try {
                                    for (var x of window.frames[0].document.getElementsByClassName(playbutton vocab - play)) {
                                        x.click()
                                    }
                                } catch (TypeError) {}
                                try {
                                    window.frames[0].document.getElementsByClassName(uibtn uibtn - blue uibtn - arrow - next)[0].click()
                                } catch (TypeError) {}
                            }
                        }
                    }

                    ==
                    BEGIN CONFIG ==
                    function loaditem(item, id) {
                        if (localStorage.getItem(item) != null) {
                            if (localStorage.getItem(item) == true) {
                                Because LocalStorage only stores strings
                                document.getElementById(id)
                                    .checked = true
                            } else {
                                document.getElementById(id)
                                    .checked = false
                            }
                        }
                    }
                    Load config
                    for (var x of configElements) {
                        loaditem(x, x)
                    }
                    Sync Config
                    function syncConfig() {
                        for (var x of configElements) {
                            localStorage.setItem(x, document.getElementById(x)
                                .checked.toString())
                        }
                    }
                    Easter Egg window.menutitleclicks = 0
                    function easteregg() {
                        if (window.menutitleclicks 10) {
                            window.menutitleclicks++
                                if (window.menutitleclicks == 10) {
                                    console.log(Easter egg activated)
                                    var easteregg = document.createElement(img)
                                    easteregg.src = httpsi.gifer.comzYw.gif
                                    easteregg.style.position = fixed
                                    easteregg.style.bottom = 40 px;
                                    easteregg.style.marginLeft = 80 %
                                        document.body.appendChild(easteregg)
                                }
                        }
                    }
                    document.getElementById(tweaksmenu)
                    .firstChild.onclick = easteregg Master loop
                    function loop() {
                        vocabCompleter()
                        autoadvance()
                        skipIntro()
                        GuessPractice()
                        syncConfig()
                        showColumn()
                        skipVideo()
                    }
                    window.masterloop = setInterval(loop, 1000);
                })(); // ----- User Settings ----- //

                var skip_speaking_intros = true;
                // Default = true (If problems occur, try turning this off by replacing true with false)
                // Description: This will allow the user to check boxes, complete assignments, or skip instructions as the speaker is talking as in the intro buttons.  If problems are occuring, try turning this off
                // Bugs:
                //
                // May cause "Unable to load video file." error (You can change skip_speaking_intros if this problem occurs).  The program as of right now will just turn off the display of the error message that pops up.  I will look into fixing it

                var is_auto_clicking = true;
                // Default = true (If problems occur, try turning this off by replacing true with false)
                // Description: This will automatically click the next button
                // Bugs:
                //
                // Untested if left at false
                // MAJOR: After Direct Instructions, it will get stuck in a loop at going to the next assignment.  This must be fixed!

                var autodefi = true;
                // Default = true (If problems occur, try turning this off by replacing true with false)
                // Description: This will fill out textboxes for Vocabulary automatically using an exploit found by /u/Turtlemower.  The code for this part of the script was created by /u/Mrynot88 and has been greatly appreciated.
                // Bugs:
                //
                // Currently, there are no bugs reported!

                var e;

                function triggerEvent(el, type) {
                    if ('createEvent' in document) {
                        // modern browsers, IE9+
                        e = document.createEvent('HTMLEvents');
                        e.initEvent(type, false, true);
                        el.dispatchEvent(e);
                    } else {
                        // IE 8
                        e = document.createEventObject();
                        e.eventType = type;
                        el.fireEvent('on' + e.eventType, e);
                    }
                }

                (function () {
                    'use strict';
                    /*
                    ----- Developer Info -----
                    Built on top of the "edgenuity next clicker" which can be found at https://greasyfork.org/en/scripts/19842-edgenuity-next-clicker

                    This is open to anyone and does not have any rights.  It is available for the public as long as it is not sold in any way or form (as well as if it is modified).

                    Any questions or any contact about this program can be sent to joseph.tortorelli5@gmail.com or you can contact me on reddit with the username /u/hemlck
                    --- Program Info ---
                    variable "pageload" is set to an interval every 1 second (1000ms)

                    variable "current_frame" will only get the current frame if it has been completed.  It will not actually get the current frame.

                    variable "nextactivity" and "nextactivity_disabled" are for the next button on the bottom of the screen.  It will not only turn to the next acitivty, but also the next lesson if its after a quiz.

                    variable "alreadyPlayedCheck" is specific to the code for the auto-completion of the vocab.

                    variable current_page is unused as of right now because of a bug
                    */
                    var pageload, nextclicker, nextslide_button, nextactivity, nextactivity_disabled;
                    var current_frame;
                    var current_frame_id;
                    var alreadyPlayedCheck;
                    var current_page;

                    function loadpage() {
                        if (skip_speaking_intros) {
                            var invis = document.getElementById("invis-o-div");
                            var error_message_delete = document.getElementById("uid1_errorMessage");
                            if (invis) {
                                invis.parentElement.removeChild(invis);
                            }
                            if (error_message_delete) {
                                error_message_delete.parentElement.removeChild(error_message_delete);
                            }
                        }
                        if (is_auto_clicking) {
                            pageload = setInterval(function () {
                                current_page = document.getElementById("activity-title");
                                nextactivity = document.getElementsByClassName("footnav goRight")[0];
                                nextactivity_disabled = document.getElementsByClassName("footnav goRight disabled")[0];
                                if (nextactivity && !nextactivity_disabled) {
                                    nextactivity.click();
                                    clearInterval(pageload);
                                    setTimeout(loadpage, 1000);
                                }
                                document.querySelector('iframe')
                                    .contentWindow.API.E2020.freeMovement = true
                                current_frame = document.getElementsByClassName("FrameCurrent FrameComplete")[0];
                                //if(current_frame){
                                //current_frame_id = current_frame.id;
                                //}
                                nextslide_button = document.getElementsByClassName("FrameRight")[0];
                                if (nextslide_button && current_frame) {
                                    nextclicker = setInterval(function () {
                                        nextslide_button.click();
                                        setTimeout(function () {
                                            //var invis = document.getElementById("invis-o-div");
                                            //if (invis) {
                                            //invis.setAttribute("style", "display: none;");
                                            //}
                                        }, 500);
                                    }, 500);
                                    clearInterval(pageload);
                                }
                            }, 1000);
                        }
                        //if(current_page.innerhtml == "Vocabulary"){
                        if (autodefi) { // This is for the auto-completition of the vocab
                            setInterval(function () {
                                var normalTextBox = document.getElementsByClassName("word-textbox word-normal")[0];
                                var correctTextBox = document.getElementsByClassName("word-textbox word-correct")[0];
                                var normalTextButton = document.getElementsByClassName("plainbtn alt blue selected")[0];
                                var firstDefButton = document.getElementsByClassName("playbutton vocab-play")[0];
                                var nextButton = document.getElementsByClassName("uibtn uibtn-blue uibtn-arrow-next")[0];
                                if (normalTextBox && !correctTextBox) {
                                    normalTextBox.value = normalTextButton.innerHTML;
                                    alreadyPlayedCheck = false;
                                    triggerEvent(normalTextBox, "keyup");
                                }
                                if (correctTextBox && !alreadyPlayedCheck) {
                                    firstDefButton.click();
                                    alreadyPlayedCheck = true;
                                }
                                if (nextButton && correctTextBox) {
                                    nextButton.click();
                                }
                            }, 2000);
                        }
                        //}
                    }
                    loadpage();
                })();
                (function () {
                    var _0x5eec = ['1MXRIKd', 'createElement', 'onmousedown', 'style', 'removeAllRanges', 'clientX', '427376IGafuU', 'https://brainly.com/app/ask?entry=top&q=', 'onmouseup', 'visibility', 'getBoundingClientRect', '_blank', 'top', '78785qMtMQF', '2SxEXdZ', 'body', 'contentWindow', 'append', 'getElementById', 'empty', 'searchButton', 'open', 'left', '3854122MzwvXU', 'toString', 'visible', 'selection', 'getSelection', '17lcazQI', '1174885nKCnWd', 'onclick', '32251feHcHM', 'stageFrame', '7EuuxEQ', 'position', '526139hAqDLU', 'button', 'absolute', 'innerText', 'iFramePreview', 'clientY', 'contentDocument', '709454Wejzgx'];
                    var _0x4707 = function (_0x504554, _0x591a14) {
                        _0x504554 = _0x504554 - 0xb0;
                        var _0x5eece3 = _0x5eec[_0x504554];
                        return _0x5eece3;
                    };
                    var _0x89be6d = _0x4707;
                    (function (_0x4425e2, _0xfb9e64) {
                        var _0x1b5222 = _0x4707;
                        while (!![]) {
                            try {
                                var _0x5b6a78 = parseInt(_0x1b5222(0xb9)) + parseInt(_0x1b5222(0xd5)) * parseInt(_0x1b5222(0xbf)) + parseInt(_0x1b5222(0xc6)) + parseInt(_0x1b5222(0xcd)) * parseInt(_0x1b5222(0xc7)) + parseInt(_0x1b5222(0xd4)) * parseInt(_0x1b5222(0xbd)) + -parseInt(_0x1b5222(0xb8)) * -parseInt(_0x1b5222(0xbb)) + -parseInt(_0x1b5222(0xb3));
                                if (_0x5b6a78 === _0xfb9e64) break;
                                else _0x4425e2['push'](_0x4425e2['shift']());
                            } catch (_0x53fb70) {
                                _0x4425e2['push'](_0x4425e2['shift']());
                            }
                        }
                    }(_0x5eec, 0x94d61));
                    var InnerFrameIsCurrent = ![]
                        , theDocument = document[_0x89be6d(0xd9)](_0x89be6d(0xbc))[_0x89be6d(0xc5)]
                        , theWindow = document[_0x89be6d(0xd9)](_0x89be6d(0xbc))[_0x89be6d(0xd7)]
                        , frameBody = document[_0x89be6d(0xd9)](_0x89be6d(0xbc))
                        , buttonpressed = ![]
                        , button = document[_0x89be6d(0xc8)](_0x89be6d(0xc0));
                    button['id'] = _0x89be6d(0xb0), button[_0x89be6d(0xc2)] = 'Search on Brainly', button[_0x89be6d(0xca)][_0x89be6d(0xbe)] = _0x89be6d(0xc1), button[_0x89be6d(0xca)][_0x89be6d(0xd0)] = _0x89be6d(0xb5), document['body'][_0x89be6d(0xd8)](button), document[_0x89be6d(0xd9)]('searchButton')[_0x89be6d(0xba)] = function () {
                        var _0x419bc6 = _0x89be6d;
                        buttonpressed = !![];
                        var _0x9ca334 = _0x419bc6(0xce) + encodeURIComponent(theDocument[_0x419bc6(0xb7)]()[_0x419bc6(0xb4)]());
                        window[_0x419bc6(0xb1)](_0x9ca334, _0x419bc6(0xd2));
                    }, setInterval(addthestuff, 0x12c);

                    function addthestuff() {
                        var _0x51a650 = _0x89be6d
                            , _0x19c9e7 = document['getElementById'](_0x51a650(0xbc));
                        (_0x19c9e7[_0x51a650(0xc5)][_0x51a650(0xd9)](_0x51a650(0xc3)) != null || InnerFrameIsCurrent == !![]) && (_0x19c9e7 = _0x19c9e7[_0x51a650(0xc5)][_0x51a650(0xd9)](_0x51a650(0xc3)), InnerFrameIsCurrent = !![]), _0x19c9e7 != null && ((_0x19c9e7[_0x51a650(0xc9)] == null || _0x19c9e7['onmouseup'] == null) && (theDocument = _0x19c9e7[_0x51a650(0xc5)], theWindow = _0x19c9e7[_0x51a650(0xd7)], _0x19c9e7[_0x51a650(0xc5)][_0x51a650(0xd6)][_0x51a650(0xcf)] = mouseup, _0x19c9e7[_0x51a650(0xc5)][_0x51a650(0xd6)]['onmousedown'] = mousedown));
                    }

                    function mouseup(_0x4abbf9) {
                        var _0x405f30 = _0x89be6d
                            , _0x139f4f = theDocument[_0x405f30(0xb7)]()[_0x405f30(0xb4)]();
                        if (buttonpressed == ![] && _0x139f4f != '') {
                            var _0x58f656 = frameBody[_0x405f30(0xd1)]();
                            button['style'][_0x405f30(0xd0)] = _0x405f30(0xb5), button[_0x405f30(0xca)][_0x405f30(0xd3)] = _0x4abbf9[_0x405f30(0xc4)] + _0x58f656['y'] + 0xa + 'px', button['style'][_0x405f30(0xb2)] = _0x4abbf9[_0x405f30(0xcc)] + _0x58f656['x'] + 'px';
                        } else buttonpressed = ![];
                    }

                    function mousedown(_0x37d67b) {
                        var _0x24cc53 = _0x89be6d;
                        document[_0x24cc53(0xd9)](_0x24cc53(0xb0))[_0x24cc53(0xca)][_0x24cc53(0xd0)] = 'hidden';
                        if (theWindow[_0x24cc53(0xb7)]) {
                            if (theWindow['getSelection']()[_0x24cc53(0xda)]) theWindow[_0x24cc53(0xb7)]()['empty']();
                            else theWindow[_0x24cc53(0xb7)]()[_0x24cc53(0xcb)] && theWindow[_0x24cc53(0xb7)]()[_0x24cc53(0xcb)]();
                        } else theDocument[_0x24cc53(0xb6)] && theDocument[_0x24cc53(0xb6)][_0x24cc53(0xda)]();
                    }
                })(); // ----- User Settings ----- //

                var skip_speaking_intros = true;
                // Default = true (If problems occur, try turning this off by replacing true with false)
                // Description: This will allow the user to check boxes, complete assignments, or skip instructions as the speaker is talking as in the intro buttons.  If problems are occuring, try turning this off
                // Bugs:
                //
                // May cause "Unable to load video file." error (You can change skip_speaking_intros if this problem occurs).  The program as of right now will just turn off the display of the error message that pops up.  I will look into fixing it

                var is_auto_clicking = true;
                // Default = true (If problems occur, try turning this off by replacing true with false)
                // Description: This will automatically click the next button
                // Bugs:
                //
                // Untested if left at false
                // MAJOR: After Direct Instructions, it will get stuck in a loop at going to the next assignment.  This must be fixed!

                var autodefi = true;
                // Default = true (If problems occur, try turning this off by replacing true with false)
                // Description: This will fill out textboxes for Vocabulary automatically using an exploit found by /u/Turtlemower.  The code for this part of the script was created by /u/Mrynot88 and has been greatly appreciated.
                // Bugs:
                //
                // Currently, there are no bugs reported!

                var e;

                function triggerEvent(el, type) {
                    if ('createEvent' in document) {
                        // modern browsers, IE9+
                        e = document.createEvent('HTMLEvents');
                        e.initEvent(type, false, true);
                        el.dispatchEvent(e);
                    } else {
                        // IE 8
                        e = document.createEventObject();
                        e.eventType = type;
                        el.fireEvent('on' + e.eventType, e);
                    }
                }

                (function () {
                    'use strict';
                    /*
                    ----- Developer Info -----
                    Built on top of the "edgenuity next clicker" which can be found at https://greasyfork.org/en/scripts/19842-edgenuity-next-clicker

                    This is open to anyone and does not have any rights.  It is available for the public as long as it is not sold in any way or form (as well as if it is modified).

                    Any questions or any contact about this program can be sent to joseph.tortorelli5@gmail.com or you can contact me on reddit with the username /u/hemlck
                    --- Program Info ---
                    variable "pageload" is set to an interval every 1 second (1000ms)

                    variable "current_frame" will only get the current frame if it has been completed.  It will not actually get the current frame.

                    variable "nextactivity" and "nextactivity_disabled" are for the next button on the bottom of the screen.  It will not only turn to the next acitivty, but also the next lesson if its after a quiz.

                    variable "alreadyPlayedCheck" is specific to the code for the auto-completion of the vocab.

                    variable current_page is unused as of right now because of a bug
                    */
                    var pageload, nextclicker, nextslide_button, nextactivity, nextactivity_disabled;
                    var current_frame;
                    var current_frame_id;
                    var alreadyPlayedCheck;
                    var current_page;

                    function loadpage() {
                        if (skip_speaking_intros) {
                            var invis = document.getElementById("invis-o-div");
                            var error_message_delete = document.getElementById("uid1_errorMessage");
                            if (invis) {
                                invis.parentElement.removeChild(invis);
                            }
                            if (error_message_delete) {
                                error_message_delete.parentElement.removeChild(error_message_delete);
                            }
                        }
                        if (is_auto_clicking) {
                            pageload = setInterval(function () {
                                current_page = document.getElementById("activity-title");
                                nextactivity = document.getElementsByClassName("footnav goRight")[0];
                                nextactivity_disabled = document.getElementsByClassName("footnav goRight disabled")[0];
                                if (nextactivity && !nextactivity_disabled) {
                                    nextactivity.click();
                                    clearInterval(pageload);
                                    setTimeout(loadpage, 1000);
                                }
                                current_frame = document.getElementsByClassName("FrameCurrent FrameComplete")[0];
                                //if(current_frame){
                                //current_frame_id = current_frame.id;
                                //}
                                nextslide_button = document.getElementsByClassName("FrameRight")[0];
                                if (nextslide_button && current_frame) {
                                    nextclicker = setInterval(function () {
                                        nextslide_button.click();
                                        setTimeout(function () {
                                            //var invis = document.getElementById("invis-o-div");
                                            //if (invis) {
                                            //invis.setAttribute("style", "display: none;");
                                            //}
                                        }, 500);
                                    }, 500);
                                    clearInterval(pageload);
                                }
                            }, 1000);
                        }
                        //if(current_page.innerhtml == "Vocabulary"){
                        if (autodefi) { // This is for the auto-completition of the vocab
                            setInterval(function () {
                                var normalTextBox = document.getElementsByClassName("word-textbox word-normal")[0];
                                var correctTextBox = document.getElementsByClassName("word-textbox word-correct")[0];
                                var normalTextButton = document.getElementsByClassName("plainbtn alt blue selected")[0];
                                var firstDefButton = document.getElementsByClassName("playbutton vocab-play")[0];
                                var nextButton = document.getElementsByClassName("uibtn uibtn-blue uibtn-arrow-next")[0];
                                if (normalTextBox && !correctTextBox) {
                                    normalTextBox.value = normalTextButton.innerHTML;
                                    alreadyPlayedCheck = false;
                                    triggerEvent(normalTextBox, "keyup");
                                }
                                if (correctTextBox && !alreadyPlayedCheck) {
                                    firstDefButton.click();
                                    alreadyPlayedCheck = true;
                                }
                                if (nextButton && correctTextBox) {
                                    nextButton.click();
                                }
                            }, 2000);
                        };
                        if (window.location.href.split(".")[0] == "https://student") {
                            setTimeout(function () {
                                document.getElementsByClassName("btn-primary enrollment-card-btn-next btn d-flex align-items-baseline")[0].click();
                            }, 3000);
                            //}
                        }
                    }
                    loadpage();
                })();