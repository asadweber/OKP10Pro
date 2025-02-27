/*!
 Responsive 1.0.6
 2014-2015 SpryMedia Ltd - datatables.net/license
*/
(function(n, p) {
    var o = function(e, k) {
        var h = function(d, a) {
            if (!k.versionCheck || !k.versionCheck("1.10.1")) throw "DataTables Responsive requires DataTables 1.10.1 or newer";
            this.s = {
                dt: new k.Api(d),
                columns: []
            };
            this.s.dt.settings()[0].responsive || (a && "string" === typeof a.details && (a.details = {
                type: a.details
            }), this.c = e.extend(!0, {}, h.defaults, k.defaults.responsive, a), d.responsive = this, this._constructor())
        };
        h.prototype = {
            _constructor: function() {
                var d = this,
                    a = this.s.dt;
                a.settings()[0]._responsive = this;
                e(n).on("resize.dtr orientationchange.dtr",
                    a.settings()[0].oApi._fnThrottle(function() {
                        d._resize()
                    }));
                a.on("destroy.dtr", function() {
                    e(n).off("resize.dtr orientationchange.dtr draw.dtr")
                });
                this.c.breakpoints.sort(function(a, c) {
                    return a.width < c.width ? 1 : a.width > c.width ? -1 : 0
                });
                this._classLogic();
                this._resizeAuto();
                var c = this.c.details;
                c.type && (d._detailsInit(), this._detailsVis(), a.on("column-visibility.dtr", function() {
                    d._detailsVis()
                }), a.on("draw.dtr", function() {
                    a.rows({
                        page: "current"
                    }).iterator("row", function(b, c) {
                        var f = a.row(c);
                        if (f.child.isShown()) {
                            var i =
                                d.c.details.renderer(a, c);
                            f.child(i, "child").show()
                        }
                    })
                }), e(a.table().node()).addClass("dtr-" + c.type));
                this._resize()
            },
            _columnsVisiblity: function(d) {
                var a = this.s.dt,
                    c = this.s.columns,
                    b, g, f = e.map(c, function(a) {
                        return a.auto && null === a.minWidth ? !1 : !0 === a.auto ? "-" : -1 !== e.inArray(d, a.includeIn)
                    }),
                    i = 0;
                b = 0;
                for (g = f.length; b < g; b++) !0 === f[b] && (i += c[b].minWidth);
                b = a.settings()[0].oScroll;
                b = b.sY || b.sX ? b.iBarWidth : 0;
                a = a.table().container().offsetWidth - b - i;
                b = 0;
                for (g = f.length; b < g; b++) c[b].control && (a -= c[b].minWidth);
                i = !1;
                b = 0;
                for (g = f.length; b < g; b++) "-" === f[b] && !c[b].control && (i || 0 > a - c[b].minWidth ? (i = !0, f[b] = !1) : f[b] = !0, a -= c[b].minWidth);
                a = !1;
                b = 0;
                for (g = c.length; b < g; b++)
                    if (!c[b].control && !c[b].never && !f[b]) {
                        a = !0;
                        break
                    }
                b = 0;
                for (g = c.length; b < g; b++) c[b].control && (f[b] = a); - 1 === e.inArray(!0, f) && (f[0] = !0);
                return f
            },
            _classLogic: function() {
                var d = this,
                    a = this.c.breakpoints,
                    c = this.s.dt.columns().eq(0).map(function(a) {
                        a = this.column(a).header().className;
                        return {
                            className: a,
                            includeIn: [],
                            auto: !1,
                            control: !1,
                            never: a.match(/\bnever\b/) ?
                                !0 : !1
                        }
                    }),
                    b = function(a, b) {
                        var d = c[a].includeIn; - 1 === e.inArray(b, d) && d.push(b)
                    },
                    g = function(f, g, e, j) {
                        if (e)
                            if ("max-" === e) {
                                j = d._find(g).width;
                                g = 0;
                                for (e = a.length; g < e; g++) a[g].width <= j && b(f, a[g].name)
                            } else if ("min-" === e) {
                            j = d._find(g).width;
                            g = 0;
                            for (e = a.length; g < e; g++) a[g].width >= j && b(f, a[g].name)
                        } else {
                            if ("not-" === e) {
                                g = 0;
                                for (e = a.length; g < e; g++) - 1 === a[g].name.indexOf(j) && b(f, a[g].name)
                            }
                        } else c[f].includeIn.push(g)
                    };
                c.each(function(b, c) {
                    for (var d = b.className.split(" "), j = !1, h = 0, k = d.length; h < k; h++) {
                        var l = e.trim(d[h]);
                        if ("all" === l) {
                            j = !0;
                            b.includeIn = e.map(a, function(a) {
                                return a.name
                            });
                            return
                        }
                        if ("none" === l || "never" === l) {
                            j = !0;
                            return
                        }
                        if ("control" === l) {
                            j = !0;
                            b.control = !0;
                            return
                        }
                        e.each(a, function(a, b) {
                            var d = b.name.split("-"),
                                e = l.match(RegExp("(min\\-|max\\-|not\\-)?(" + d[0] + ")(\\-[_a-zA-Z0-9])?"));
                            e && (j = !0, e[2] === d[0] && e[3] === "-" + d[1] ? g(c, b.name, e[1], e[2] + e[3]) : e[2] === d[0] && !e[3] && g(c, b.name, e[1], e[2]))
                        })
                    }
                    j || (b.auto = !0)
                });
                this.s.columns = c
            },
            _detailsInit: function() {
                var d = this,
                    a = this.s.dt,
                    c = this.c.details;
                "inline" === c.type &&
                    (c.target = "td:first-child");
                var b = c.target;
                e(a.table().body()).on("click", "string" === typeof b ? b : "td", function() {
                    if (e(a.table().node()).hasClass("collapsed") && a.row(e(this).closest("tr")).length) {
                        if (typeof b === "number") {
                            var c = b < 0 ? a.columns().eq(0).length + b : b;
                            if (a.cell(this).index().column !== c) return
                        }
                        c = a.row(e(this).closest("tr"));
                        if (c.child.isShown()) {
                            c.child(false);
                            e(c.node()).removeClass("parent")
                        } else {
                            var f = d.c.details.renderer(a, c[0]);
                            c.child(f, "child").show();
                            e(c.node()).addClass("parent")
                        }
                    }
                })
            },
            _detailsVis: function() {
                var d = this,
                    a = this.s.dt,
                    c = a.columns().indexes().filter(function(b) {
                        var c = a.column(b);
                        return c.visible() ? null : e(c.header()).hasClass("never") ? null : b
                    }),
                    b = !0;
                if (0 === c.length || 1 === c.length && this.s.columns[c[0]].control) b = !1;
                b ? a.rows({
                    page: "current"
                }).eq(0).each(function(b) {
                    b = a.row(b);
                    if (b.child()) {
                        var c = d.c.details.renderer(a, b[0]);
                        !1 === c ? b.child.hide() : b.child(c, "child").show()
                    }
                }) : a.rows({
                    page: "current"
                }).eq(0).each(function(b) {
                    a.row(b).child.hide()
                })
            },
            _find: function(d) {
                for (var a =
                        this.c.breakpoints, c = 0, b = a.length; c < b; c++)
                    if (a[c].name === d) return a[c]
            },
            _resize: function() {
                var d = this.s.dt,
                    a = e(n).width(),
                    c = this.c.breakpoints,
                    b = c[0].name,
                    g = this.s.columns,
                    f;
                for (f = c.length - 1; 0 <= f; f--)
                    if (a <= c[f].width) {
                        b = c[f].name;
                        break
                    }
                var i = this._columnsVisiblity(b),
                    c = !1;
                f = 0;
                for (a = g.length; f < a; f++)
                    if (!1 === i[f] && !g[f].never) {
                        c = !0;
                        break
                    }
                e(d.table().node()).toggleClass("collapsed", c);
                d.columns().eq(0).each(function(a, b) {
                    d.column(a).visible(i[b])
                })
            },
            _resizeAuto: function() {
                var d = this.s.dt,
                    a = this.s.columns;
                if (this.c.auto && -1 !== e.inArray(!0, e.map(a, function(a) {
                        return a.auto
                    }))) {
                    d.table().node();
                    var c = d.table().node().cloneNode(!1),
                        b = e(d.table().header().cloneNode(!1)).appendTo(c),
                        g = e(d.table().body().cloneNode(!1)).appendTo(c);
                    e(d.table().footer()).clone(!1).appendTo(c);
                    d.rows({
                        page: "current"
                    }).indexes().flatten().each(function(a) {
                        var b = d.row(a).node().cloneNode(!0);
                        d.columns(":hidden").flatten().length && e(b).append(d.cells(a, ":hidden").nodes().to$().clone());
                        e(b).appendTo(g)
                    });
                    var f = d.columns().header().to$().clone(!1);
                    e("<tr/>").append(f).appendTo(b);
                    "inline" === this.c.details.type && e(c).addClass("dtr-inline collapsed");
                    c = e("<div/>").css({
                        width: 1,
                        height: 1,
                        overflow: "hidden"
                    }).append(c);
                    c.find("th.never, td.never").remove();
                    c.insertBefore(d.table().node());
                    d.columns().eq(0).each(function(b) {
                        a[b].minWidth = f[b].offsetWidth || 0
                    });
                    c.remove()
                }
            }
        };
        h.breakpoints = [{
            name: "desktop",
            width: Infinity
        }, {
            name: "tablet-l",
            width: 1024
        }, {
            name: "tablet-p",
            width: 768
        }, {
            name: "mobile-l",
            width: 480
        }, {
            name: "mobile-p",
            width: 320
        }];
        h.defaults = {
            breakpoints: h.breakpoints,
            auto: !0,
            details: {
                renderer: function(d, a) {
                    var c = d.cells(a, ":hidden").eq(0).map(function(a) {
                        var c = e(d.column(a.column).header()),
                            a = d.cell(a).index();
                        if (c.hasClass("control") || c.hasClass("never")) return "";
                        var f = d.settings()[0],
                            f = f.oApi._fnGetCellData(f, a.row, a.column, "display");
                        (c = c.text()) && (c += ":");
                        return '<li data-dtr-index="' + a.column + '"><span class="dtr-title">' + c + '</span> <span class="dtr-data">' + f + "</span></li>"
                    }).toArray().join("");
                    return c ? e('<ul data-dtr-index="' + a + '"/>').append(c) : !1
                },
                target: 0,
                type: "inline"
            }
        };
        var m = e.fn.dataTable.Api;
        m.register("responsive()", function() {
            return this
        });
        m.register("responsive.index()", function(d) {
            d = e(d);
            return {
                column: d.data("dtr-index"),
                row: d.parent().data("dtr-index")
            }
        });
        m.register("responsive.rebuild()", function() {
            return this.iterator("table", function(d) {
                d._responsive && d._responsive._classLogic()
            })
        });
        m.register("responsive.recalc()", function() {
            return this.iterator("table", function(d) {
                d._responsive && (d._responsive._resizeAuto(), d._responsive._resize())
            })
        });
        h.version = "1.0.6";
        e.fn.dataTable.Responsive = h;
        e.fn.DataTable.Responsive = h;
        e(p).on("init.dt.dtr", function(d, a) {
            if ("dt" === d.namespace && (e(a.nTable).hasClass("responsive") || e(a.nTable).hasClass("dt-responsive") || a.oInit.responsive || k.defaults.responsive)) {
                var c = a.oInit.responsive;
                !1 !== c && new h(a, e.isPlainObject(c) ? c : {})
            }
        });
        return h
    };
    "function" === typeof define && define.amd ? define(["jquery", "datatables"], o) : "object" === typeof exports ? o(require("jquery"), require("datatables")) : jQuery && !jQuery.fn.dataTable.Responsive &&
        o(jQuery, jQuery.fn.dataTable)
})(window, document);