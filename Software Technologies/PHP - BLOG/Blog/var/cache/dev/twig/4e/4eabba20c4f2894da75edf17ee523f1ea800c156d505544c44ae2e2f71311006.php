<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_7880f13a7540cd2f760c302286fb51a9d3ae4c0e27ed5bf3d2d0b67360461022 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_c08a6ef3292bf6d8429696924df0ea5bea3c442b3caa0f7805404e5a73ead783 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c08a6ef3292bf6d8429696924df0ea5bea3c442b3caa0f7805404e5a73ead783->enter($__internal_c08a6ef3292bf6d8429696924df0ea5bea3c442b3caa0f7805404e5a73ead783_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_c08a6ef3292bf6d8429696924df0ea5bea3c442b3caa0f7805404e5a73ead783->leave($__internal_c08a6ef3292bf6d8429696924df0ea5bea3c442b3caa0f7805404e5a73ead783_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_40c3c5fb450a00f88b8fd1eaf5382ae889fec79c0010f4962c087fbe741d159e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_40c3c5fb450a00f88b8fd1eaf5382ae889fec79c0010f4962c087fbe741d159e->enter($__internal_40c3c5fb450a00f88b8fd1eaf5382ae889fec79c0010f4962c087fbe741d159e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_40c3c5fb450a00f88b8fd1eaf5382ae889fec79c0010f4962c087fbe741d159e->leave($__internal_40c3c5fb450a00f88b8fd1eaf5382ae889fec79c0010f4962c087fbe741d159e_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_12c00b571d2517feb446c332cd87f2965ad4ee56d76826bffb6ad16d73eeab67 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_12c00b571d2517feb446c332cd87f2965ad4ee56d76826bffb6ad16d73eeab67->enter($__internal_12c00b571d2517feb446c332cd87f2965ad4ee56d76826bffb6ad16d73eeab67_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_12c00b571d2517feb446c332cd87f2965ad4ee56d76826bffb6ad16d73eeab67->leave($__internal_12c00b571d2517feb446c332cd87f2965ad4ee56d76826bffb6ad16d73eeab67_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_4daf2601651f559cd626a0187e6955f2f5c4c3e733bd893aae8ec6c5893e1f17 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4daf2601651f559cd626a0187e6955f2f5c4c3e733bd893aae8ec6c5893e1f17->enter($__internal_4daf2601651f559cd626a0187e6955f2f5c4c3e733bd893aae8ec6c5893e1f17_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_4daf2601651f559cd626a0187e6955f2f5c4c3e733bd893aae8ec6c5893e1f17->leave($__internal_4daf2601651f559cd626a0187e6955f2f5c4c3e733bd893aae8ec6c5893e1f17_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}
