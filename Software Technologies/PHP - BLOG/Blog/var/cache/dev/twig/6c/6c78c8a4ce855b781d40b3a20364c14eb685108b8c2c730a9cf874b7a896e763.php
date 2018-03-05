<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_84628d403590814b1b772b275435d7a4312c72fd083eb18c546fc27c5c8fbae9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
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
        $__internal_6e3da0492d3e0ae1fccf50a8aa6777f6fa45bac3e342bc94aad5ab1271a31a54 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6e3da0492d3e0ae1fccf50a8aa6777f6fa45bac3e342bc94aad5ab1271a31a54->enter($__internal_6e3da0492d3e0ae1fccf50a8aa6777f6fa45bac3e342bc94aad5ab1271a31a54_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6e3da0492d3e0ae1fccf50a8aa6777f6fa45bac3e342bc94aad5ab1271a31a54->leave($__internal_6e3da0492d3e0ae1fccf50a8aa6777f6fa45bac3e342bc94aad5ab1271a31a54_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_34903109efe84d0643333f1dec217aef890c73667230840cd214985b9205573c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_34903109efe84d0643333f1dec217aef890c73667230840cd214985b9205573c->enter($__internal_34903109efe84d0643333f1dec217aef890c73667230840cd214985b9205573c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_34903109efe84d0643333f1dec217aef890c73667230840cd214985b9205573c->leave($__internal_34903109efe84d0643333f1dec217aef890c73667230840cd214985b9205573c_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_72b1bca470de8952e45b156f060d41e614b29c80599cdd63f6999d7eec35c268 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_72b1bca470de8952e45b156f060d41e614b29c80599cdd63f6999d7eec35c268->enter($__internal_72b1bca470de8952e45b156f060d41e614b29c80599cdd63f6999d7eec35c268_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_72b1bca470de8952e45b156f060d41e614b29c80599cdd63f6999d7eec35c268->leave($__internal_72b1bca470de8952e45b156f060d41e614b29c80599cdd63f6999d7eec35c268_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_e327462cd57b5d6c9cba956fc980ec8ca11b562fefc03360bc8de9edeb3ad09b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e327462cd57b5d6c9cba956fc980ec8ca11b562fefc03360bc8de9edeb3ad09b->enter($__internal_e327462cd57b5d6c9cba956fc980ec8ca11b562fefc03360bc8de9edeb3ad09b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_e327462cd57b5d6c9cba956fc980ec8ca11b562fefc03360bc8de9edeb3ad09b->leave($__internal_e327462cd57b5d6c9cba956fc980ec8ca11b562fefc03360bc8de9edeb3ad09b_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
